using System;

class hnk8{
    static void timeConversion(string s) {

        //string dat1=s.Substring(0,s.Length-2);
        string dat2=(s.Split('P')).ToString();
        Console.WriteLine(dat2);
        //DateTime dat=Convert.ToDateTime(dat1);
        
    }
    static void Main(){
        string h="07:05:45PM";
        timeConversion(h);
    }
}