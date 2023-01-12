using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.Metrics;
namespace PrimeService.Tests{
     [TestClass]
     public class UnitTest1
{
 [TestMethod]
    public void Invalid_TVShowName_length()
    {
        string name = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ";
        Assert.IsFalse(Notlonger(name));
    }

     [TestMethod]
    public void valid_tvshowname_length()
    {
        string tvshowname = "ABCD";
        Assert.IsTrue(Notlonger(tvshowname));
}
     [TestMethod]
    public void director_invalid_gender(){
        string gender = "P";
        Assert.IsFalse(Notvalidgender(gender));

         
    }
     [TestMethod]
        public void director_valid_gender(){
            string gender = "M";
            Assert.IsTrue(Notvalidgender(gender));
        }

        bool Notlonger(string name){
            return name.Length <=100;
        }

        bool Notvalidgender (string name){
            return (name.Equals("M") || name.Equals("F")) ;
        }
}
}