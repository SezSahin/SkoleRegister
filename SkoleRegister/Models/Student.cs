using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkoleRegister.Models
{
    public class Student : INotifyPropertyChanged
    {
        private string firstname { get; set; }
        private string lastname { get; set; }
        private string fullname { get; set; }
        private int cpr { get; set; }
        private string contactPerson { get; set; }
        private int phoneNo { get; set; }
        private string email { get; set; }



        public string FirstName
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
                OnPropertyChanged("FirstName");
                OnPropertyChanged("FullName");
            }
        }
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion 

        public string LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
                OnPropertyChanged("LastName");
                OnPropertyChanged("FullName");
            }
        }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public int Cpr
        {
            get
            {
                return cpr;
            }
            set
            {
                cpr = value;
                OnPropertyChanged("Cpr");
            }
        }
        public string ContactPerson
        {
            get
            {
                return contactPerson;
            }
            set
            {
                contactPerson = value;
                OnPropertyChanged("ContactPerson");
            }
        }
        public int PhoneNo
        {
            get
            {
                return phoneNo;
            }
            set
            {
                phoneNo = value;
                OnPropertyChanged("PhoneNo");
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }


        public IEnumerable<Student> getStudentsFromDB(int classId)
        {
            var dm = Connector.Instance.getConnection();
            dm.Open();
            string query = @"SELECT * FROM STUDENTS WHERE ClassId =" + classId;
            SqlCommand cmd = new SqlCommand(query, dm);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            List<Student> students = new List<Student>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.ForegroundColor = ConsoleColor.White;

                    Student s = new Student();
                    s.FirstName = reader["Fornavn"].ToString();
                    s.LastName = reader["Efternavn"].ToString();
                    s.Cpr = Int32.Parse(reader["Cpr"].ToString());
                    s.ContactPerson = reader["Kontaktperson"].ToString();
                    s.PhoneNo = Int32.Parse(reader["Telefonnummer"].ToString());
                    s.Email = reader["Email"].ToString();

                    students.Add(s);

                }
            }

            else
            {
                throw new Exception("ur course is boring there are no students SRRYNOTSRRY");
            }
            return students;
        }
    }
}