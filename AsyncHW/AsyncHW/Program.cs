using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace AutoLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet dataSet = new DataSet("shopDB");

            DataTable orders = new DataTable("Orders");

            DataTable customers = new DataTable("Customers");

            DataTable employees = new DataTable("Employees");

            DataTable orderDetail = new DataTable("OrderDetail");

            DataTable product = new DataTable("Products");

            dataSet.Tables.Add(orders);

            dataSet.Tables.Add(customers);

            dataSet.Tables.Add(employees);

            dataSet.Tables.Add(orderDetail);

            dataSet.Tables.Add(product);

            orders.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn
                    {
                        ColumnName ="id",
                        AllowDBNull = false,
                        AutoIncrement = true,
                        AutoIncrementSeed = 1,
                        AutoIncrementStep = 1,
                        Unique = true,
                        DataType = typeof(int),
                    },
                    new DataColumn
                    {
                        ColumnName ="order_sum",
                        AllowDBNull = false,
                        DataType = typeof(int),

                    },
                    new DataColumn
                    {
                        ColumnName ="order_date",
                        AllowDBNull = false,
                        DataType = typeof(DateTime),
                    },
                    new DataColumn
                    {
                        ColumnName ="seller",
                        AllowDBNull = false,
                        DataType = typeof(string),
                    }
                });
            DataRow firstRow = orders.NewRow();

            customers.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn
                    {
                        ColumnName ="id",
                        AllowDBNull = false,
                        AutoIncrement = true,
                        AutoIncrementSeed = 1,
                        AutoIncrementStep = 1,
                        Unique = true,
                        DataType = typeof(int),
                    },
                    new DataColumn
                    {
                        ColumnName ="fullname",
                        AllowDBNull = false,
                        DataType = typeof(string),

                    },
                    new DataColumn
                    {
                        ColumnName ="age",
                        AllowDBNull = false,
                        DataType = typeof(int),
                    }
                });
            DataRow secondRow = customers.NewRow();

            employees.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn
                    {
                        ColumnName ="id",
                        AllowDBNull = false,
                        AutoIncrement = true,
                        AutoIncrementSeed = 1,
                        AutoIncrementStep = 1,
                        Unique = true,
                        DataType = typeof(int),
                    },
                    new DataColumn
                    {
                        ColumnName ="fullname",
                        AllowDBNull = false,
                        DataType = typeof(string),

                    },
                    new DataColumn
                    {
                        ColumnName ="age",
                        AllowDBNull = false,
                        DataType = typeof(int),
                    }
                });
            DataRow thirdRow = employees.NewRow();

            orderDetail.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn
                    {
                        ColumnName ="id",
                        AllowDBNull = false,
                        AutoIncrement = true,
                        AutoIncrementSeed = 1,
                        AutoIncrementStep = 1,
                        Unique = true,
                        DataType = typeof(int),
                    },
                    new DataColumn
                    {
                        ColumnName ="seller_name",
                        AllowDBNull = false,
                        DataType = typeof(string),

                    },
                    new DataColumn
                    {
                        ColumnName ="customer_name",
                        AllowDBNull = false,
                        DataType = typeof(string),
                    },
                    new DataColumn
                    {
                        ColumnName ="order_sum",
                        AllowDBNull = false,
                        DataType = typeof(int),
                    },
                    new DataColumn
                    {
                        ColumnName ="order_date",
                        AllowDBNull = false,
                        DataType = typeof(DateTime)
                    },
                });
            DataRow forthRow = orderDetail.NewRow();

            product.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn
                    {
                        ColumnName ="id",
                        AllowDBNull = false,
                        AutoIncrement = true,
                        AutoIncrementSeed = 1,
                        AutoIncrementStep = 1,
                        Unique = true,
                        DataType = typeof(int),
                    },
                    new DataColumn
                    {
                        ColumnName ="product_name",
                        AllowDBNull = false,
                        DataType = typeof(int),

                    },
                    new DataColumn
                    {
                        ColumnName ="product_price",
                        AllowDBNull = false,
                        DataType = typeof(int),
                    },
                    new DataColumn
                    {
                        ColumnName ="product_descrip",
                        AllowDBNull = false,
                        DataType = typeof(string),
                    },
                    new DataColumn
                    {
                        ColumnName ="order_date",
                        AllowDBNull = false,
                        DataType = typeof(DateTime)
                    },
                });
            DataRow fifthRow = product.NewRow();

            orders.PrimaryKey = new DataColumn[] { orders.Columns["id"] };
            customers.PrimaryKey = new DataColumn[] { customers.Columns["id"] };
            employees.PrimaryKey = new DataColumn[] { employees.Columns["id"] };
            orderDetail.PrimaryKey = new DataColumn[] { orderDetail.Columns["id"] };
            product.PrimaryKey = new DataColumn[] { product.Columns["id"] };
        }
    }
}