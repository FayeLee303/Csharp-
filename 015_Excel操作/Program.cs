using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Excel操作
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "装备信息.xls";
            string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + fileName + ";" +
                             ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"";
            //创建链接到数据源的对象
            OleDbConnection connection = new OleDbConnection(connectString);
            //打开链接
            connection.Open();
            string sql = "select*from[Sheet1$]";//这是一个查询命令
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql,connection);
            DataSet dataSet = new DataSet();//用来存放数据，用来存放DataTable的
            adapter.Fill(dataSet);//表示把查询的结果（dataSet）填充到dataset里面
            connection.Close();//把链接关闭,释放连接资源

            //取得数据
            DataTableCollection tableCollection = dataSet.Tables;//获取当前集合中的所有表格
            DataTable table = tableCollection[0]; //刚刚只向dataset里放了一个表格Sheet1，所以这里取得索引为0的表格就是要找的表格
            //取得表格中的数据
            //取得table中所有的行
            DataRowCollection rowCollection = table.Rows;//返回一个行的集合
            //遍历行的集合，取得每个行的datarow对象
            foreach (DataRow row in rowCollection)
            {
                //取得row里前8列的数据，索引0-7
                for (int i = 0; i < 8; i++)
                {
                    Console.Write(row[i] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
