///<summary>
///Blaine Simcox II
///CIT 255
///Jeff Straw
///Final Exam
///12/5/2013
///DataRepository Class for Traversing and 
///Using Instruments.accdb
///</summary>
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.Common;
using InstrumentsUI.Properties;

namespace InstrumentsUI
{
    class DataRepository
    {
       #region DbObjects
		
        /// <summary>
        /// Class-Level Polymorphic DbConnection
        /// </summary>
        private DbConnection orchestraCon = null;

        /// <summary>
        /// Class-Level Polymorphic DbCommand
        /// </summary>
        private DbCommand orchestraCommand = null;

        /// <summary>
        /// Class-Level Polymorphic DbReader
        /// </summary>
        private DbDataReader orchestraReader = null; 
	    #endregion

       #region SQL Statements

        /// <summary>
        /// String for getting just Didstinct Types from Database
        /// Used in GetType() method for stocking cboMaster
        /// </summary>
        private const string selecTypes = @"SELECT DISTINCT Type FROM Instruments";

        /// <summary>
        /// Default Select Statement for entire database
        /// </summary>
        private const string defaultString = @"SELECT Instrument, Type "
                                     + "FROM Instruments ORDER BY "
                                     + "Instrument ASC;";

        /// <summary>
        /// Dynamic Select Statement that is fed Type
        /// To get Just that type of Instrument
        /// </summary>
        /// <param name="typ">parameter to finish Select Statement</param>
        /// <returns>Instruments by Type Only</returns>
        private string selectByType(string typ)
        {
            return String.Format(@"SELECT Instrument, Type "
                                    + "From Instruments WHERE "
                                    + "Type = '{0}'"
                                    + "ORDER BY Instrument ASC;", typ);
        } 
        #endregion

       #region Methods

        /// <summary>
        /// Gets a list of Section Enums
        /// </summary>
        /// <returns>Section Enums for cboMaster</returns>
        public List<Section> GetType()
        {
            var sqlResults = ConnectionMethodSection(selecTypes);

            usingType(sqlResults);

            return sqlResults;
        }

        /// <summary>
        /// Gets a list of all Instruments
        /// </summary>
        /// <returns>List of all Instruments</returns>
        public List<Instrument> GetInstruments()
        {
            var sqlResults = ConnectionMethodInstrument();

            orchestraCommand.CommandText = defaultString;

            usingInstruments(sqlResults);

            return sqlResults;
        }

        /// <summary>
        /// Gets Instrument by Type
        /// </summary>
        /// <param name="typ">Used to load Sql Selection Statment</param>
        /// <returns>List of Instruments By Type</returns>
        public List<Instrument> GetInstruments(string typ)
        {
            var sqlResults = ConnectionMethodInstrument();

            if (typ == null)
            {
                orchestraCommand.CommandText = defaultString;
            }
            else
                orchestraCommand.CommandText = selectByType(typ);

            usingInstruments(sqlResults);

            return sqlResults;
        } 
        #endregion

       #region Using and Connection Statements
        
        /// <summary>
        /// Connection Method for GetInstruments()
        /// and its overloaded method
        /// </summary>
        /// <returns>List for Storing SQL Statement Results</returns>
        private List<Instrument> ConnectionMethodInstrument()
        {
            var sqlResults = new List<Instrument>();
            orchestraCon = new OleDbConnection(Settings.Default.orchestraConnection);
            orchestraCommand = orchestraCon.CreateCommand();
            orchestraCommand.CommandType = CommandType.Text;
            return sqlResults;
        }

        /// <summary>
        /// Connection method for loading Types
        /// From Database casting them into Section Objects
        /// </summary>
        /// <param name="sqlCommand">Parameter for reusability
        /// Can be loaded with SQL statements For Dynamic usage</param>
        /// <returns>List for Storing SQL Statement</returns>
        private List<Section> ConnectionMethodSection(string sqlCommand)
        {
            var sqlResults = new List<Section>();
            orchestraCon = new OleDbConnection(Settings.Default.orchestraConnection);
            orchestraCommand = orchestraCon.CreateCommand();
            orchestraCommand.CommandType = CommandType.Text;

            orchestraCommand.CommandText = sqlCommand;
            return sqlResults;
        }

        /// <summary>
        /// Using Statment with Exception handling for GetType()
        /// </summary>
        /// <param name="sqlResults">Fully Loaded List of Section Type</param>
        private void usingType(List<Section> sqlResults)
        {
            using (orchestraCon)
            {
                try
                {
                    orchestraCon.Open();
                    orchestraReader = orchestraCommand.ExecuteReader();

                    while (orchestraReader.Read())
                    {
                        string InstrumentType = (string)orchestraReader["Type"];

                        sqlResults.Add((Section)Enum.Parse(typeof(Section), InstrumentType));
                    }
                    orchestraReader.Close();
                }
                catch (OleDbException ex)
                {
                    throw ex;
                }
                finally
                {
                    orchestraCon.Close();
                }
            }
        }

        /// <summary>
        /// Using Statement with Exception Handling for 
        /// both version of GetInstruments() method
        /// </summary>
        /// <param name="sqlResults">List Containing Resulting SQL Query Data</param>
        private void usingInstruments(List<Instrument> sqlResults)
        {
            using (orchestraCon)
            {
                try
                {
                    orchestraCon.Open();
                    orchestraReader = orchestraCommand.ExecuteReader();

                    while (orchestraReader.Read())
                    {
                        string name = (string)orchestraReader["Instrument"];
                        string InstrumentType = (string)orchestraReader["Type"];

                        Section type = (Section)Enum.Parse(typeof(Section), InstrumentType);

                        Instrument I = new Instrument(name, type);
                        sqlResults.Add(I);
                    }
                    orchestraReader.Close();
                }
                catch (OleDbException ex)
                {
                    throw ex;
                }
                finally
                {
                    orchestraCon.Close();
                }
            }
        } 
        #endregion  
    }
}
