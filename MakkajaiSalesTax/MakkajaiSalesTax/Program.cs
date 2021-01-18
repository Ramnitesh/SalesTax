using MakkajaiSalesTax.Interface;
using MakkajaiSalesTax.Models;
using MakkajaiSalesTax.Repository;
using System;
using System.Collections.Generic;

namespace MakkajaiSalesTax
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ISalesTax isalesTax = SalesTaxImplementation.getApi();
                isalesTax.countSalesTax();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
