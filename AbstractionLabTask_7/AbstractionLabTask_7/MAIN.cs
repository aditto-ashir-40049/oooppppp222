using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionLabTask_7
{
    class MAIN
    {
        static void Main()
        {
            

            SAVINGS S = new SAVINGS();
            S.AcName = "Aditto";
            S.AccId = "19kjhbDI";
            S.balance = 258710;
            S.TrancNO = 5;
            S.ShowAccountInfo();
            S.Withdraw(2800);
            Console.WriteLine();
         
            
             SpecialSaving fix =new SpecialSaving(); 
            fix.AcName = "Aditto";
            fix.AccId = "19kjhbDI";
            
            fix.balance = 14930;
            fix.openingBalance = 5627;
            fix.ShowAccountInfo();
            fix.Withdraw(2500);
            Console.WriteLine();


           Fixed  SS = new Fixed();
            SS.AcName = "Aditto";
            SS.AccId = "19kjhbDI";
            SS.TurnerYear = 2030;
            SS.WithdrawalYear= Int32.Parse(DateTime.Now.Year.ToString());
            SS.balance = 75394;
            SS.ShowAccountInfo();
            SS.Withdraw(2587);
            Console.WriteLine();

            OverDraft OD = new OverDraft();
            OD.AcName = "Aditto";
            OD.AccId = "19kjhbDI";
            OD.balance = 6000;
            OD.openingOverDraftBalance = 78530;
            OD.ShowAccountInfo();
            OD.Withdraw(3250);









            Console.ReadLine();

        }
    }
}
