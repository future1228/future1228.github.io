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
namespace Enable_UIAutomation.Features.Factfind_V2.Client.FactFind.AssessingClientRisk
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("AssessingClientRisk", new string[] {
            "Reg"}, Description="\tIn order to avoid silly mistakes\r\n\tAs a math idiot\r\n\tI want to be told the sum o" +
        "f two numbers", SourceFile="Features\\Factfind_V2\\Client\\FactFind\\AssessingClientRisk\\AssessingClientRisk.feat" +
        "ure", SourceLine=1)]
    public partial class AssessingClientRiskFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AssessingClientRisk.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AssessingClientRisk", "\tIn order to avoid silly mistakes\r\n\tAs a math idiot\r\n\tI want to be told the sum o" +
                    "f two numbers", ProgrammingLanguage.CSharp, new string[] {
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
        
        public virtual void AddPartnerAssessingClientRisk(string usePreviousRiskProfile, string previousRiskProfile, string previousRiskProfileScore, string previousRiskProfileDate, string clientExperienceLevel, string notes, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Smoke",
                    "LoginEnableTaur"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Partner Assessing Client Risk", null, @__tags);
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
 testRunner.And("I select the factfind \"Schroders Personal Wealth Individual Fact Find\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.And("I select Include Partner and Update", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And("I click the \"Assessing Client Risk \" from left nav", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.When(string.Format("I fill the Assessing Client Risk form for client as \"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\"" +
                        ",\"{5}\"", usePreviousRiskProfile, previousRiskProfile, previousRiskProfileScore, previousRiskProfileDate, clientExperienceLevel, notes), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
 testRunner.And(string.Format("I fill the Assessing Client Risk form for partner as \"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}" +
                        "\",\"{5}\"", usePreviousRiskProfile, previousRiskProfile, previousRiskProfileScore, previousRiskProfileDate, clientExperienceLevel, notes), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.Then("I save and complete the Assessing Client Risk", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add Partner Assessing Client Risk, Yes", new string[] {
                "Smoke",
                "LoginEnableTaur"}, SourceLine=21)]
        public virtual void AddPartnerAssessingClientRisk_Yes()
        {
#line 9
this.AddPartnerAssessingClientRisk("Yes", "3 - Medium Risk", "425", "7-June-2019", "Experienced", "Assessing Risk", ((string[])(null)));
#line hidden
        }
        
        public virtual void AddClientAssessingClientRisk(string usePreviousRiskProfile, string previousRiskProfile, string previousRiskProfileScore, string previousRiskProfileDate, string clientExperienceLevel, string notes, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "LoginEnableTaur"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add client Assessing Client Risk", null, @__tags);
#line 26
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 27
 testRunner.Given("I am on Clients search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
 testRunner.And("I select the newly created client", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("I click on Fact Find button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And("I select the factfind \"Schroders Personal Wealth Individual Fact Find\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.And("I exclude the partner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.And("I click the \"Assessing Client Risk \" from left nav", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.When(string.Format("I fill the Assessing Client Risk form for client as \"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\"" +
                        ",\"{5}\"", usePreviousRiskProfile, previousRiskProfile, previousRiskProfileScore, previousRiskProfileDate, clientExperienceLevel, notes), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.Then("I save and complete the Assessing Client Risk", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add client Assessing Client Risk, Yes", new string[] {
                "LoginEnableTaur"}, SourceLine=37)]
        public virtual void AddClientAssessingClientRisk_Yes()
        {
#line 26
this.AddClientAssessingClientRisk("Yes", "3 - Medium Risk", "425", "7-June-2019", "Experienced", "Assessing Risk", ((string[])(null)));
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
