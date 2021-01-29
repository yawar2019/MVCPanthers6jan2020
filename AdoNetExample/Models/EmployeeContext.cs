using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace AdoNetExample.Models
{
    public class EmployeeContext
    {
        SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=MuthuDb;Integrated Security=true");

        public List<EmployeeModel> GetEmployees()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();
            SqlCommand cmd = new SqlCommand("sp_getEmployees", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                EmployeeModel emp = new EmployeeModel();
                emp.EmpId = Convert.ToInt32(dr[0]);
                emp.EmpName = Convert.ToString(dr[1]);
                emp.EmpSalary = Convert.ToInt32(dr[2]);

                listObj.Add(emp);

            }
            return listObj;

        }

        public int SaveEmployee(string EmpName, int EmpSalary)
        {
            SqlCommand cmd = new SqlCommand("sp_insertEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@EmpName", EmpName);
            cmd.Parameters.AddWithValue("@Salary", EmpSalary);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }


        public EmployeeModel GetEmployeeById(int? id)
        {
            EmployeeModel Obj = new EmployeeModel();
            SqlCommand cmd = new SqlCommand("sp_getEmployeesById", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpId", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Obj.EmpId = Convert.ToInt32(dr[0]);
                Obj.EmpName = Convert.ToString(dr[1]);
                Obj.EmpSalary = Convert.ToInt32(dr[2]);
            }
            return Obj;

        }



        public int UpdateEmployee(EmployeeModel obj)
        {
            SqlCommand cmd = new SqlCommand("sp_UpdateEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@EmpId", obj.EmpId);
            cmd.Parameters.AddWithValue("@EmpName", obj.EmpName);
            cmd.Parameters.AddWithValue("@Salary", obj.EmpSalary);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }


        public int DeleteEmployee(int? id)
        {
            SqlCommand cmd = new SqlCommand("sp_DeleteEmployeeById", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@EmpId", id);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}