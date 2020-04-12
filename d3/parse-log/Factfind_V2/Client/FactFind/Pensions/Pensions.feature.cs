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
namespace Enable_UIAutomation.Features.Factfind_V2.Client.FactFind.Pensions
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Pensions", new string[] {
            "Reg"}, Description="\tAs an advisor\r\n\tI want to view and add Pension plans for clients\r\n\tSo i can prov" +
        "ide clients with the most appropriate factfind possible", SourceFile="Features\\Factfind_V2\\Client\\FactFind\\Pensions\\Pensions.feature", SourceLine=1)]
    public partial class PensionsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Pensions.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Pensions", "\tAs an advisor\r\n\tI want to view and add Pension plans for clients\r\n\tSo i can prov" +
                    "ide clients with the most appropriate factfind possible", ProgrammingLanguage.CSharp, new string[] {
                        "Reg"});
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
        
        public virtual void ViewPensionPlansOfAClient(string factfind, string doYouHaveAnyOtherPensionPlans, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Smoke",
                    "LoginEnableTaur"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("View Pension plans of a client", null, @__tags);
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 10
 testRunner.Given("I am on Clients search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
 testRunner.And("I select the newly created client", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("I click on Fact Find button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.And(string.Format("I select the existing \"{0}\"", factfind), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.And("I click the \"Pensions\" from left nav", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.When(string.Format("I choose the \"{0}\"  pension option", doYouHaveAnyOtherPensionPlans), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("I see all the Pension plans listed for that client", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("View Pension plans of a client, Schroders Personal Wealth Individual Fact Find", new string[] {
                "Smoke",
                "LoginEnableTaur"}, SourceLine=18)]
        public virtual void ViewPensionPlansOfAClient_SchrodersPersonalWealthIndividualFactFind()
        {
#line 9
this.ViewPensionPlansOfAClient("Schroders Personal Wealth Individual Fact Find", "yes", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add an existing pension plan for a client", new string[] {
                "LoginEnableTaur"}, SourceLine=21)]
        public virtual void AddAnExistingPensionPlanForAClient()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add an existing pension plan for a client", null, new string[] {
                        "LoginEnableTaur"});
#line 22
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 23
 testRunner.Given("I am on Clients search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
 testRunner.And("I select the newly created client", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.And("I click on Fact Find button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.And("I select the existing \"Schroders Personal Wealth Individual Fact Find\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.And("I click the \"Pensions\" from left nav", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And("I choose to Add a Pension plan from the existing plans", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.When("I select a pension plan", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.And("I save the existing pension plan", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.Then("I can see \"Saved Successfully saved.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void AddANewPensionPlanForAClient(string pensionType, string life, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Smoke",
                    "LoginEnableTaur"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add a new Pension plan for a client", null, @__tags);
#line 35
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 36
 testRunner.Given("I am on Clients search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 37
 testRunner.And("I select the newly created client", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("I click on Fact Find button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And("I select the existing \"Schroders Personal Wealth Individual Fact Find\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And("I click the \"Pensions\" from left nav", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("I choose to enter details for a pension not on the system", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.And(string.Format("I enter pension details \"{0}\" and \"{1}\"", pensionType, life), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.When("I save the pension", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
 testRunner.Then("I can see \"Saved Pension has been successfully saved.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add a new Pension plan for a client, Type_01", new string[] {
                "Smoke",
                "LoginEnableTaur"}, SourceLine=46)]
        public virtual void AddANewPensionPlanForAClient_Type_01()
        {
#line 35
this.AddANewPensionPlanForAClient("Type_01", "Self", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Mandatory Field Validation", new string[] {
                "validation",
                "LoginEnableTaur"}, SourceLine=50)]
        public virtual void MandatoryFieldValidation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Mandatory Field Validation", null, new string[] {
                        "validation",
                        "LoginEnableTaur"});
#line 51
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 52
 testRunner.Given("I am on Clients search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 53
 testRunner.And("I select the newly created client", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.And("I click on Fact Find button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
 testRunner.And("I select the existing \"Schroders Personal Wealth Individual Fact Find\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
 testRunner.And("I click the \"Pensions\" from left nav", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.And("I choose to enter details for a pension not on the system", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.And("I save the pension", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.And("I can see the error message as \"Cannot Save The Life field is required.; The Type" +
                    " field is required.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.And("I enter pension details \"Type_02\" and \"Self\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.When("I save the pension", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 62
 testRunner.Then("I can see \"Saved Pension has been successfully saved.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Data Integrity Validation", new string[] {
                "validation",
                "LoginEnableTaur"}, SourceLine=65)]
        public virtual void DataIntegrityValidation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Data Integrity Validation", null, new string[] {
                        "validation",
                        "LoginEnableTaur"});
#line 66
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 67
 testRunner.Given("I am on Clients search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 68
 testRunner.And("I select the newly created client", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.And("I click on Fact Find button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.And("I select the existing \"Schroders Personal Wealth Individual Fact Find\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.And("I click the \"Pensions\" from left nav", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.And("I choose to enter details for a pension not on the system", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.And("I enter pension details \"Type_03\" and \"Self\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.And("I enter the Personal Contribution value as \"INVALID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.And("I save the pension", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.And("I can see the error message as \"Cannot Save The value \'INVALID\' is not valid for " +
                    "Personal Contribution.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
 testRunner.And("I remove the Personal Contribution value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.And("I enter the Company Contribution value as \"INVALID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.And("I save the pension", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.And("I can see the error message as \"Cannot Save The value \'INVALID\' is not valid for " +
                    "Company Contribution.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.And("I remove the Company Contribution value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.And("I enter the value field as \"INVALID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
 testRunner.And("I save the pension", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
 testRunner.And("I can see the error message as \"Cannot Save The value \'INVALID\' is not valid for " +
                    "Value.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void PartnerPensionSimplification(string transitionalProtectionType, string lifetimeAllowanceFactor, string notes, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "LoginEnableTaur"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Partner Pension Simplification", null, @__tags);
#line 87
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 88
 testRunner.Given("I am on Clients search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 89
 testRunner.And("I select the newly created client", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
 testRunner.And("I click on Fact Find button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.And("I select the existing \"Schroders Personal Wealth Individual Fact Find\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.And("I select Include Partner and Update", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.And("I click the \"Pensions\" from left nav", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.When(string.Format("I fill the form for client as \"{0}\",\"{1}\",\"{2}\"", transitionalProtectionType, lifetimeAllowanceFactor, notes), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 95
 testRunner.And(string.Format("I fill the form for partner as \"{0}\",\"{1}\",\"{2}\"", transitionalProtectionType, lifetimeAllowanceFactor, notes), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
 testRunner.Then("I Save and complete the pension simplification", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Partner Pension Simplification, Individual Protection", new string[] {
                "LoginEnableTaur"}, SourceLine=99)]
        public virtual void PartnerPensionSimplification_IndividualProtection()
        {
#line 87
this.PartnerPensionSimplification("Individual Protection", "25", "simplification", ((string[])(null)));
#line hidden
        }
        
        public virtual void ClientExtraDBInfo(string yearJoinedScheme, string pensionableSalary, string accrualRate, string additionalYearsPurchased, string additionalLumpSum, string widowsDeathInServicePensionPerAnnum, string dependentDeathInServicePensionPerAnnum, string earlyRetirementAge, string earlyRetirementPenalty, string hMRCCurrentCashEquivalent, string currentTransferValue, string beneficiaries, string notes, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "LoginEnableTaur"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("client Extra DB Info", null, @__tags);
#line 104
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 105
 testRunner.Given("I am on Clients search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 106
 testRunner.And("I select the newly created client", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
 testRunner.And("I click on Fact Find button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
 testRunner.And("I select the existing \"Schroders Personal Wealth Individual Fact Find\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
 testRunner.And("I exclude the partner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
 testRunner.And("I click the \"Pensions\" from left nav", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
 testRunner.And("I click the Extra DB Info Tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
 testRunner.When(string.Format("I fill the Extra DB Info form for client as \"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"" +
                        "{6}\",\"{7}\",\"{8}\",\"{9}\",\"{10}\",\"{11}\",\"{12}\"", yearJoinedScheme, pensionableSalary, accrualRate, additionalYearsPurchased, additionalLumpSum, widowsDeathInServicePensionPerAnnum, dependentDeathInServicePensionPerAnnum, earlyRetirementAge, earlyRetirementPenalty, hMRCCurrentCashEquivalent, currentTransferValue, beneficiaries, notes), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 113
 testRunner.Then("I Save and complete the pension simplification", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("client Extra DB Info, 1977", new string[] {
                "LoginEnableTaur"}, SourceLine=116)]
        public virtual void ClientExtraDBInfo_1977()
        {
#line 104
this.ClientExtraDBInfo("1977", "50000", "20", "13", "45", "53", "67", "60", "500", "234", "97", "brandon", "extra info", ((string[])(null)));
#line hidden
        }
        
        public virtual void PartnerExtraDBInfo(string yearJoinedScheme, string pensionableSalary, string accrualRate, string additionalYearsPurchased, string additionalLumpSum, string widowsDeathInServicePensionPerAnnum, string dependentDeathInServicePensionPerAnnum, string earlyRetirementAge, string earlyRetirementPenalty, string hMRCCurrentCashEquivalent, string currentTransferValue, string beneficiaries, string notes, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "LoginEnableTaur"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("partner Extra DB Info", null, @__tags);
#line 120
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 121
 testRunner.Given("I am on Clients search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 122
 testRunner.And("I select the newly created client", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
 testRunner.And("I click on Fact Find button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
 testRunner.And("I select the existing \"Schroders Personal Wealth Individual Fact Find\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
 testRunner.And("I select Include Partner and Update", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
 testRunner.And("I click the \"Pensions\" from left nav", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 127
 testRunner.And("I click the Extra DB Info Tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 128
 testRunner.When(string.Format("I fill the Extra DB Info form for client as \"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"" +
                        "{6}\",\"{7}\",\"{8}\",\"{9}\",\"{10}\",\"{11}\",\"{12}\"", yearJoinedScheme, pensionableSalary, accrualRate, additionalYearsPurchased, additionalLumpSum, widowsDeathInServicePensionPerAnnum, dependentDeathInServicePensionPerAnnum, earlyRetirementAge, earlyRetirementPenalty, hMRCCurrentCashEquivalent, currentTransferValue, beneficiaries, notes), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 129
 testRunner.And(string.Format("I fill the Extra DB Info form for partner as \"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\"," +
                        "\"{6}\",\"{7}\",\"{8}\",\"{9}\",\"{10}\",\"{11}\",\"{12}\"", yearJoinedScheme, pensionableSalary, accrualRate, additionalYearsPurchased, additionalLumpSum, widowsDeathInServicePensionPerAnnum, dependentDeathInServicePensionPerAnnum, earlyRetirementAge, earlyRetirementPenalty, hMRCCurrentCashEquivalent, currentTransferValue, beneficiaries, notes), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 130
 testRunner.Then("I Save and complete the pension simplification", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("partner Extra DB Info, 1977", new string[] {
                "LoginEnableTaur"}, SourceLine=133)]
        public virtual void PartnerExtraDBInfo_1977()
        {
#line 120
this.PartnerExtraDBInfo("1977", "50000", "20", "13", "45", "53", "67", "60", "500", "234", "97", "brandon", "extra info", ((string[])(null)));
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
