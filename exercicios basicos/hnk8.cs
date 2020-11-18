using System;
//Given a time in -hour AM/PM format, convert it to military (24-hour) time.
class hnk8{
    /*
    for some reason this code isnt working in the hackerhank 
    static string timeConversion(string s) {
        String dat1=s.Substring(0,s.Length-2);
        String dat2=s.Substring(s.Length-2,2);
        String dat3=dat1+" "+dat2;
        DateTime dat=DateTime.Parse(dat3);
        String result=dat.ToString();
        return(result.Substring(11,8));
    }*/
    //the code bellow works
    static string timeConversion(string s) {
       DateTime time=DateTime.Parse(s);
        return(time.ToString("HH:mm:ss"));
    }
    static void Main(string[] args){
        string h="07:05:45PM";
        Console.WriteLine(timeConversion(h));
    }
}