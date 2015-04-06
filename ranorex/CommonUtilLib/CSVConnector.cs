///////////////////////////////////////////////////////////////////////////////////////////////////
//
// This file is part of the  R A N O R E X  Project.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;


/// <summary>
/// Represents a data connector to a CSV-file
/// </summary>
class CSVConnector
{
    private string fileName = null;
    private DataTable dt = null;

    /// <summary>
    /// Initializes a new instance of the <see cref="CSVConnector"/> class.
    /// </summary>
    /// <param name="fileName">The path to the CSV file <see cref="CSVConnector"/></param>
    public CSVConnector(String fileName)
    {
        try
        {
            if (fileName == null)
                return;

            this.fileName = fileName;
            dt = new DataTable();
            ParseCSVData();
        }
        catch (Exception e)
        {
            Console.WriteLine("{0} Open Connector Error: ", e.ToString());
        }
    }

    /// <summary>
    /// Gets the Data Collection Rows
    /// </summary>
    public DataRowCollection Rows
    {
        get { return dt.Rows; }
    }

    /// <summary>
    /// Gets the Data Columns
    /// </summary>
    public DataColumnCollection Header
    {
        get { return dt.Columns; }
    }

    private void ParseCSVData()
    {
        try
        {
            String[] csvData = System.IO.File.ReadAllLines(fileName);

            if (csvData.Length == 0)
                return;

            String[] headings = csvData[0].Split(';');

            foreach (string header in headings)
            {
                dt.Columns.Add(header, typeof(string));
            }
            
            for (int j = 1; j < csvData.Length; j++)
            {
                DataRow row = dt.NewRow();

                //If row does not start with "#" go into the if statement and execute code inside.  
                if(!csvData[j].StartsWith("#"))
     			{  
                for (int i = 0; i < headings.Length; i++)
                {
                    row[i] = csvData[j].Split(';')[i];
                }
                dt.Rows.Add(row);
            	}
        	}
        }
        catch (Exception e)
        {
            Console.WriteLine("{0} Parse CSV Data Error: ", e.ToString());
        }
    }
}
