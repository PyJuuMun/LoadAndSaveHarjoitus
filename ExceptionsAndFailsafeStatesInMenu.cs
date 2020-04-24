using System;
using System.Collections.Generic;
using System.Text;

namespace LoadAndSaveHarjoitus
{
    class ExceptionsAndFailsafeStatesInMenu
    {
		//Kokeellinen class MenuOptions classin kanssa toimimaan, saatetaan poistaa myöhemmin, alla olevaa koodia yritetty rakentaa pari kertaa, poistettu ja kirjoitettu uudestaan

		MenuOptions menuOptions = new MenuOptions();

		public void EmploymentErrorCheck(string continueOn)
        {
			try
			{
				
			}
			catch (Exception)
			{

				throw;
			}
        }
    }
}
