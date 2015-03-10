using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using MvcStudent.Models;

namespace MvcStudent.BusinessLogic
{
    public class Category
    {
        string conStr = WebConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        internal List<CategoryModel> FetchCustomer()
        {
            List<CategoryModel> categoryList = new List<CategoryModel>();
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("Select CATEGORY_ID, CATEGORY_Name, CATEGORY_Description FROM CATEGORY", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            CategoryModel category;
            foreach(DataRow dr in dt.Rows)
            {
                category = new CategoryModel();
                category.CATEGORY_ID = Convert.ToInt32(dr["CATEGORY_ID"]);
                category.CATEGORY_Name = dr["CATEGORY_Name"].ToString();
                category.CATEGORY_Description = dr["CATEGORY_Description"].ToString();
                categoryList.Add(category);
            }
            return categoryList;
        }
    }
}