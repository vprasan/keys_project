﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace testspecflow.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Login", Description="\tTest the Properties functionality of the application\r\n\tverify if the login as ow" +
        "ner are working as expected", SourceFile="Features\\AddProperty.feature", SourceLine=0)]
    public partial class LoginFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AddProperty.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Login", "\tTest the Properties functionality of the application\r\n\tverify if the login as ow" +
                    "ner are working as expected", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void VerifyIfTheOwnerIsAbleToAddPropertyDetailsFinancialAndTenantDetails_(
                    string testcase, 
                    string username, 
                    string password, 
                    string property, 
                    string streetNumber, 
                    string route, 
                    string city, 
                    string post, 
                    string region, 
                    string desc, 
                    string rent, 
                    string bedroom, 
                    string bath, 
                    string car, 
                    string built, 
                    string pprice, 
                    string mprice, 
                    string hvalue, 
                    string repayment, 
                    string repaystart, 
                    string expenseamt, 
                    string expensedesc, 
                    string expensedate, 
                    string email, 
                    string fname, 
                    string lname, 
                    string sdate, 
                    string edate, 
                    string ramt, 
                    string psdate, 
                    string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify if the owner is able to add property details,financial and tenant details." +
                    "", null, exampleTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 testRunner.Given("I navigate to keys web application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.And(string.Format("I  type  \"{0}\", \"{1}\"", username, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
 testRunner.When("I click login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
 testRunner.Then("I should be able to login successfully and Dasboard page should be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 9
 testRunner.When("I click on Owners and click on the Properties button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then("I should navigate to My properties Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
 testRunner.When("I click on the Add New Property Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then("I should be on the Add New Properties Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
 testRunner.When(string.Format("I enter all the mandatory fields \"{0}\", \"{1}\", \"{2}\",\"{3}\", \"{4}\", \"{5}\",\"{6}\",\"{" +
                        "7}\",\"{8}\", \"{9}\", \"{10}\",\"{11}\" and click on Next button", property, streetNumber, route, city, post, region, desc, rent, bedroom, bath, car, built), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.Then("I should Navigate to Financial Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
 testRunner.When(string.Format("i enter all the required fields for Financial Details \"{0}\", \"{1}\", \"{2}\", \"{3}\"," +
                        " \"{4}\",\"{5}\", \"{6}\", \"{7}\" and click on Next Button", pprice, mprice, hvalue, repayment, repaystart, expenseamt, expensedesc, expensedate), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("I should navigate to Add Tenant Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
 testRunner.When(string.Format("I entered all the mandatory fields in the Tenant Details Page \"{0}\", \"{1}\", \"{2}\"" +
                        ", \"{3}\", \"{4}\", \"{5}\", \"{6}\" and click Save button", email, fname, lname, sdate, edate, ramt, psdate), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then("I should see all the entered values saved.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify if the owner is able to add property details,financial and tenant details." +
            ", 1", SourceLine=20)]
        public virtual void VerifyIfTheOwnerIsAbleToAddPropertyDetailsFinancialAndTenantDetails__1()
        {
#line 4
this.VerifyIfTheOwnerIsAbleToAddPropertyDetailsFinancialAndTenantDetails_("1", "vvpveed@gmail.com", "harii@123", "Rose Garden", "36", "campbell street", "sydney", "2020", "NSW", "spacious and no commonn walls", "500", "2", "1", "1", "2015", "500000", "400000", "600000", "1000", "22/12/2017", "5000", "electric fitting for the house", "22/10/2015", "sugar@gmail.com", "Peter", "John", "22/01/2018", "22/01/2019", "500", "22/01/2018", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify if the owner is able to add property details,financial and tenant details." +
            ", 2", SourceLine=20)]
        public virtual void VerifyIfTheOwnerIsAbleToAddPropertyDetailsFinancialAndTenantDetails__2()
        {
#line 4
this.VerifyIfTheOwnerIsAbleToAddPropertyDetailsFinancialAndTenantDetails_("2", "vvpveed@gmail.com", "harii@123", "Sun City", "45", "cambridge street", "perth", "2021", "WA", "Best for nature lovers", "400", "1", "1", "1", "2016", "400000", "300000", "400000", "900", "22/11/2017", "4000", "overall furnishing and labour", "22/10/2016", "sugar@gmail.com", "Emily", "Joe", "22/01/2017", "22/01/2018", "400", "22/01/2017", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify if the owner is able to add property details,financial and tenant details." +
            ", 3", SourceLine=20)]
        public virtual void VerifyIfTheOwnerIsAbleToAddPropertyDetailsFinancialAndTenantDetails__3()
        {
#line 4
this.VerifyIfTheOwnerIsAbleToAddPropertyDetailsFinancialAndTenantDetails_("3", "vvpveed@gmail.com", "harii@123", "Metro Elite", "65", "ilford street", "queensland", "2023", "BNE", "sutalbe for all age groups", "700", "4", "3", "2", "2018", "900000", "800000", "700000", "2000", "22/01/2018", "3000", "electric fitting for the house", "22/10/2017", "sugar@gmail.com", "Jacob", "Justin", "22/10/2017", "22/10/2018", "700", "22/10/2017", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify if the owner is able to add property details,financial and tenant details." +
            ", 4", SourceLine=20)]
        public virtual void VerifyIfTheOwnerIsAbleToAddPropertyDetailsFinancialAndTenantDetails__4()
        {
#line 4
this.VerifyIfTheOwnerIsAbleToAddPropertyDetailsFinancialAndTenantDetails_("4", "vvpveed@gmail.com", "harii@123", "Palace city", "25", "westham street", "darwin", "2024", "NT", "lots of free space and parks", "600", "3", "2", "1", "2014", "800000", "600000", "900000", "600", "22/12/2015", "8000", "Maintenance charges", "22/10/2017", "sugar@gmail.com", "Peter", "John", "22/01/2018", "22/01/2019", "600", "22/01/2018", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify if the owner is able to add property details,financial and tenant details." +
            ", 5", SourceLine=20)]
        public virtual void VerifyIfTheOwnerIsAbleToAddPropertyDetailsFinancialAndTenantDetails__5()
        {
#line 4
this.VerifyIfTheOwnerIsAbleToAddPropertyDetailsFinancialAndTenantDetails_("5", "vvpveed@gmail.com", "harii@123", "Metro Elite", "65", "ilford street", "queensland", "2023", "BNE", "sutalbe for all age groups", "700", "4", "3", "2", "2018", "900000", "800000", "700000", "2000", "22/01/2018", "3000", "electric fitting for the house", "22/10/2017", "sugar@gmail.com", "Jacob", "Justin", "22/10/2017", "22/10/2018", "700", "22/10/2017", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
