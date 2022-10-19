using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp5
{


    internal class Task
    {

        private string summary;
        private DateTime dueDate;
        private bool isComleted;
        private string details;
        private string info;
        private bool isoverDue;

        public Task(string summary)
        {
            Summary = summary;
           

        }
        //
        public Task (string summary, DateTime dueDate)
            :this(summary)
        {
     
            DueDate = dueDate;

        }


        public string Summary
        {
            get { return summary; }
            set 
            { 
                if (value != null || value != "")
                    summary = value;

                throw new ArgumentException("Summary can not be null");
            }
        }
        public DateTime DueDate
        {
            get { return dueDate; }
            set
            {
                if(value <=  DateTime.Now.AddDays(-30))
                    dueDate = value;

                throw new ArgumentException("Wrong date format");
            }
        }
        public bool IsCompleted
        {
            get { return isComleted; }
            set
            {
                if(value == true || value == false)
                isComleted = value;
            }
        }
        public string Details
        {
            get { return details; }
            set
            {
                if(value != null)
                details = value;

                value = "";
            }
        }
        public bool IsOverDue
        {
            get 
            {  
            
            if (DateAndTime.Now <= dueDate)
                    return true;

                return false;
            
            }
          
        }
        public string Info
        {
            get { return info.ToString(); }

        }

        public override string ToString()
        {
            return string.Format("{0:00}:{1:00}:{2:00}", Summary, dueDate, IsCompleted);
        }


    }
}
