using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DataAccess.Models;

namespace DataAccess.Factory
{
    // Singleton Factory pattern class to creates Portfolio based on file 
    // allows for flexibility in various portfolio source file types/databases
    public class PortfolioFactory
    {
        private static PortfolioFactory _instance;

        public static PortfolioFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PortfolioFactory();
                }
                return _instance;
            }
        }

        private PortfolioFactory()
        {

        } 

        public Portfolio GetPortfolio(String path)
        {
            FileInfo info = new FileInfo(path);
            switch(info.Extension)
            {
                case (".xml"):
                    {
                        return new XMLFileManager(path).GetPortfolio();
                    }
                default:
                    {
                        return null;
                    }
            }  
        }

    }
}
