﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameServerWebAPI.WebTests
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.WebTesting;
    using Microsoft.VisualStudio.TestTools.WebTesting.Rules;


    public class HealthCheckCoded : WebTest
    {

        public HealthCheckCoded()
        {
            this.Context.Add("LocalDevelopmentServer", "https://localhost:44305");
            this.PreAuthenticate = true;
            this.Proxy = "default";
        }

        public override IEnumerator<WebTestRequest> GetRequestEnumerator()
        {
            // Initialize validation rules that apply to all requests in the WebTest
            if ((this.Context.ValidationLevel >= Microsoft.VisualStudio.TestTools.WebTesting.ValidationLevel.High))
            {
                ValidationRuleFindText validationRule1 = new ValidationRuleFindText();
                validationRule1.FindText = "Unhealthy";
                validationRule1.IgnoreCase = false;
                validationRule1.UseRegularExpression = false;
                validationRule1.PassIfTextFound = false;
                this.ValidateResponse += new EventHandler<ValidationEventArgs>(validationRule1.Validate);
            }

            WebTestRequest request1 = new WebTestRequest((this.Context["LocalDevelopmentServer"].ToString() + "/health"));
            yield return request1;
            request1 = null;
        }
    }
}
