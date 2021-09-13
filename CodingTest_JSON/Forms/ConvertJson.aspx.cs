using CodingTest_JSON.Model;
using Newtonsoft.Json;
using System;
using System.IO;

namespace CodingTest_JSON.Forms
{
    public partial class ConvertJson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Create a JSON object and save  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCreate_Click(object sender, EventArgs e)
        {
            //define the employee class as an object
            Employee emp = new Employee
            {
                firstName = txtFirstName.Text,
                lastName = txtLastName.Text
            };

            //store the serialized data inside a string variable.
            string result = JsonConvert.SerializeObject(emp);

            // save the data
            string path = AppDomain.CurrentDomain.BaseDirectory+ "JSON" + "//" + Guid.NewGuid()+ ".json";

            //StreamWriter to save the .JSON file at the given path.
            using (var tw = new StreamWriter(path, append: true))
            {
                tw.WriteLine(result.ToString());
                tw.Close();
            }
            //Clear the text once we we click on create
            Clear();
        }
        /// <summary>
        /// Clears the text
        /// </summary>
        public void Clear()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
        }
    }
}