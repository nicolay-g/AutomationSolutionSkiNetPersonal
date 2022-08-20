using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Library.Abstract
{
    public abstract class PageObject
    {
        protected IWebElement SearchContext { get; private set; }

        public PageObject(IWebElement webElement)
        {
            SearchContext = webElement;
        }
    }
}
