﻿using System;

namespace DbEngine
{
    public class QueryTransform
    {
        /*
    * This method will split the query string based on space into an array of words
    * and display it on console.
    */
        public string[] GetSplitString(string query)
        {
            string low=query.ToLower();
            string[] strs = low.Split(' ');
            
            return strs;
        }

        /*
   * Extract the name of the file from the query. File name can be found after a
   * space after "from" clause. Note: CSV file can contain a field that contains
   * from as a part of the column name. For eg: from_date,from_hrs etc.
   * 
   * Please consider this while extracting the file name in this method.
   */
        public string GetFileName(string query)
        {
            string[] strs = query.Split(' ');
            string sendmyvalue = null;
           foreach(string str in strs)
           {
                if(str=="ipl.csv")
                {
                    sendmyvalue = str;
                }
                else
                {
                    continue;

                }

           }
            return sendmyvalue;
                
        }

        /*
	 * This method is used to extract the baseQuery from the query string. BaseQuery
	 * contains from the beginning of the query till the where clause.
	 * 
	 * Note: 1. The query might not contain where clause but contain order by or
	 * group by clause 2. The query might not contain where, order by or group by
	 * clause 3. The query might not contain where, but can contain both group by
	 * and order by clause.
	 */
        public string GetBaseQuery(string query)
        {
            //string mysub = query.Substring(0, 21);
            //return mysub;
            string sub = null;
            if (query.Contains("where"))
            {
                string[] subquery = query.Split(" where");
                sub = subquery[0];
               
            }
            return sub;
        }




        //Step II

        /*
	     * This method will extract the fields to be selected from the query string. The
	     * query string can have multiple fields separated by comma. The extracted
	     * fields will be stored in a String array which is to be printed in console as
	     * well as to be returned by the method
	     * 
	     * Note: 1. The field name or value in the condition can contain keywords as a
	     * substring. For eg: from_city,job_order_no,group_no etc. 2. The field name can
	     * contain '*'
	     * 
	     */

        public string[] GetFieldsNames(string queryString)
        {
            string samp = queryString;
            int IndexOfselect = samp.IndexOf("select ");
            int IndexOffrom = samp.IndexOf(" from");
            string res = samp.Substring(IndexOfselect + 7, IndexOffrom - 7);
            string[] feilds = res.Split(",");
            return feilds;
        }

        /*
	     * This method is used to extract the conditions part from the query string. The
	     * conditions part contains starting from where keyword till the next keyword,
	     * which is either group by or order by clause. In case of absence of both group
	     * by and order by clause, it will contain till the end of the query string.
	     * Note: 1. The field name or value in the condition can contain keywords as a
	     * substring. For eg: from_city,job_order_no,group_no etc. 2. The query might
	     * not contain where clause at all.
	     */
        public string GetConditionsPartQuery(string queryString)
        {
            string con = null;
            if (queryString.Contains("where"))
            {
                string[] cond = queryString.Split("where ");
                con = cond[1];
            }
            return con;
        }

        /*
	     * This method will extract condition(s) from the query string. The query can
	     * contain one or multiple conditions. In case of multiple conditions, the
	     * conditions will be separated by AND/OR keywords. for eg: Input: select
	     * city,winner,player_match from ipl.csv where season > 2014 and city
	     * ='Bangalore'
	     * 
	     * This method will return a string array ["season > 2014","city ='Bangalore'"]
	     * and print the array
	     * 
	     * Note: 1. The field name or value in the condition can contain keywords as a
	     * substring. For eg: from_city,job_order_no,group_no etc. 2. The query might
	     * not contain where clause at all.
	     */
        public string[] GetConditions(string queryString)
        {           
            queryString = queryString.ToLower();
            string[] mainsub = queryString.Split("where ");
            string[] conditions = null;
            if (mainsub[1].Contains("and"))
            {
                conditions = mainsub[1].Split(" and ");
            }
            else if (mainsub[1].Contains("or"))
            {
                conditions= mainsub[1].Split(" or ");
            }
            return conditions;
        }

        

    

    //Step III

    /*
     * This method will extract logical operators(AND/OR) from the query string. The
     * extracted logical operators will be stored in a String array which will be
     * returned by the method and the same will be printed Note: ------- 1. AND/OR
     * keyword will exist in the query only if where conditions exists and and it
     * contains multiple conditions. 2. AND/OR can exist as a substring in the
     * conditions as well. For eg: name='Alexander',color='Red' etc. Please consider
     * these as well when extracting the logical operators.
     * 
     */

    public string[] GetLogicalOperators(string queryString)
        {
            string[] subquery = new string[2];  
            queryString = queryString.ToLower();
            if (queryString.Contains("and"))
            {
                subquery[0] = "and";
            }
            if (queryString.Contains("or"))
            {
                subquery[1]= "or";
            }
            return subquery;

        }

        /*
	     * This method extracts the order by fields from the query string. Note: 1. The
	     * query string can contain more than one order by fields. 2. The query string
	     * might not contain order by clause at all. 3. The field names, condition
	     * values might contain "order" as a substring. For eg: order_number,job_order
	     * Consider this while extracting the order by fields
	    */
        public string[] GetOrderByFields(string queryString)
        {

            queryString = queryString.ToLower();
            string[] order = queryString.Split("order by ");
            string[] getOrderBy = order[1].Split(",");
            return getOrderBy;
        }

        //Step IV

        /*
	     * This method extracts the group by fields from the query string. Note: ------
	     * 1. The query string can contain more than one group by fields. 2. The query
	     * string might not contain group by clause at all. 3. The field names,
	     * condition values might contain "group" as a substring. For eg: newsgroup_name
	     * Consider this while extracting the group by fields
	    */
        public string[] GetGroupByFields(string queryString)
        {
            queryString = queryString.ToLower();
            string[] group = queryString.Split("group by ");
            string[] getOrderBy = group[1].Split(",");
            return getOrderBy;
        }

        /*
	 * This method extracts the aggregate functions from the query string. Note: 1.
	 * aggregate functions will start with "sum"/"count"/"min"/"max"/"avg" followed
	 * by "(" 2. The field names might contain "sum"/"count"/"min"/"max"/"avg" as a
	 * substring. For eg: account_number,consumed_qty,nominee_name
	 * 
	 * Consider this while extracting the aggregate functions
	 */
        public string[] GetAggregateFunctions(string queryString)
        {
            string samp = queryString;
            int IndexOfselect = samp.IndexOf("select ");
            int IndexOffrom = samp.IndexOf(" from");
            string res = samp.Substring(IndexOfselect + 7, IndexOffrom - 7);
            string[] aggfun = res.Split(",");
            return aggfun;
        }
    }
}
