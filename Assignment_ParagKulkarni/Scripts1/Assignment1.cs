
//Convert the string to Title Case and Camel case.
using System;

namespace Scripts1
{
    public class Assignment1
    {
        
        string appentstr = null, finalstr = null;
        //string[] output = null;
        public string toTitleCase(string input)
        {
            string[] strsplit = input.Split(' ');
            for (int i = 0; i < strsplit.Length; i++)
            {
                //char[] strarr=strsplit[i].ToCharArray();
                //output[i]=strarr[0].ToString().ToUpper();
                for (int j = 0; j < strsplit[i].Length; j++)
                {
                    if (j == 0)
                    {
                        appentstr = strsplit[i][j].ToString().ToUpper();
                    }
                    else
                    {
                        appentstr += strsplit[i][j].ToString().ToLower();
                    }
                }
                if (i == 0)
                {
                    finalstr = appentstr;
                }
                else
                {
                    finalstr += " ";
                    finalstr += appentstr;
                }
            }
           // Console.WriteLine(finalstr);
            return finalstr;
        }
        public string ToCamelCaseFunc(string input)
        {
            string[] strsplit = input.Split(' ');
            //string output=null;
                for(int i =0;i<strsplit.Length;i++)
                {
                    for(int j = 0; j < strsplit[i].Length; j++)
                    {
                        if(i==0 && j==0)
                        appentstr = strsplit[0][0].ToString().ToLower();
                        else
                        {
                            if(j==0)
                            appentstr += strsplit[i][0].ToString().ToUpper();
                            else
                            appentstr += strsplit[i][j].ToString().ToLower();
                        }
                    }

                }
            return appentstr;
        }
    }
}
