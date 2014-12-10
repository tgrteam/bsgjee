

#region license

/// <License>
/// <FileLabel>BearcatSoft(R) Library</FileLabel>
/// <Copyrights>Copyright (C) 2003 - 2004, BearcatSoft(R). All rights reserved.
/// The software and associated documentation supplied hereunder 
/// are the proprietary information of BearcatSoft(R) and are supplied 
/// subject to licence terms.
/// </Copyrights>
/// <Product>This file was generated by BearcatSoft Genarator(R)</Product>
/// <LicenseDetails>http://BearcatSoft.no-ip.com/GeneratorLicense</LicenseDetails>
/// <LicenseDetails2>http://www.BearcatSoft.com/GeneratorLicense</LicenseDetails2>
/// <Contact>http://BearcatSoft.no-ip.com</Contact>
/// <Contact2>http://www.BearcatSoft.com</Contact2>
/// <Company>BearcatSoft(R)</Company>
/// <Trademarks>BearcatSoft(R), BearcatSoft Generator(R) are a registered trademarks of BearcatSoft company</Trademarks>
/// </License>
/// 
#endregion

#region usings

using System;
using System.Collections.Specialized ;

using BearcatSoft.BSGen.Framework;
using BearcatSoft.BSGen.Framework.Components.CBSGFieldItem;
using BearcatSoft.BSGen.Framework.Components.CBSGFieldItemGroup;
using BearcatSoft.BSGen.Framework.Components.CBSGClass ;
using BearcatSoft.BSGen.Framework.Components.CBSGTemplate;
using BearcatSoft.BSGen.Framework.Components.CBSGView ;
using BearcatSoft.BSGen.Framework.Components.CBSGForeignField ;
using BearcatSoft.BSGen.Framework.Components.CBSGForeignFieldGroup ;

using BearcatSoft.BSGen.Engine.Classes.FieldsHelpers;
using BearcatSoft.BSGen.Engine.Generator.Components ;
using BearcatSoft.BSGen.Engine.Classes.ModelHelpers ;
using BearcatSoft.BSGen.EngineF35.Generator.DataAccessProjects.BSGA.Components.DAL.Providers;
#endregion




namespace BearcatSoft.BSGen.EngineF35.Generator.oraclejee_mvc.src.main.java.com.sprhib.dao
{	

	[GenerateANDCondition(new string[]{"GENER_LIB_DATAACCESS_DATAACCESS"})]
    [BSGTemplate(typeof(BSGClass), SourceCodeType.Java_SourceCodeType, @"oraclejee-mvc\src\main\java\com\sprhib\controller\")]
    public class BSG_OracleJEE_DAO_Controller : ProxyBaseClass
	{


        #region protected override Generate functions

		protected override void GenerateSourceForModel(BearcatSoft.BSGen.Framework.Components.CBSGModel.BSGModel item, BSGSourceFile src)
		{
		}

		protected override void GenerateSource(
            BSGClass item
            , BSGSourceFile src)
		{
            BearcatSoft.BSGen.Framework.Components.CBSGCLSType.BSGCLSType.BSGCLSType_Modified = "java";
            //BearcatSoft.BSGen.Framework.Components.CBSGCLSType.BSGCLSType.BSGCLSType_Modified = "java";

            this.InitializeGenerator(
                item
                , src
                , ModelForGenerator);

            src.FileName = "" + this.IBSBSGClass.MHIBSNameJavaCase + @"Controller";

            this.IBSBSGClass.SetChoosedDataSet_First();
            
            this.Src.AddLn(@"
package com.sprhib.controller;

import java.util.List;

import org.oraclejeeframework.beans.factory.annotation.Autowired;
import org.oraclejeeframework.stereotype.Controller;
import org.oraclejeeframework.web.bind.annotation.ModelAttribute;
import org.oraclejeeframework.web.bind.annotation.PathVariable;
import org.oraclejeeframework.web.bind.annotation.RequestMapping;
import org.oraclejeeframework.web.bind.annotation.RequestMethod;
import org.oraclejeeframework.web.servlet.ModelAndView;
");

            this.Src.AddLn(@"
import com.sprhib.model." + this.IBSBSGClass.MHIBSNameJavaCase + @";
import com.sprhib.service." + this.IBSBSGClass.MHIBSNameJavaCase + @"Service;");

            this.Src.AddLn(@"

@Controller
@RequestMapping(value=" + PP() + @"/" + this.IBSBSGClass.MHIBSNameLowerCase + @"" + PP() + @")");

            this.Src.AddLn(@"
public class " + this.IBSBSGClass.MHIBSNameJavaCase + @"Controller {");

            this.Src.AddLn(@"
	
	@Autowired
	private " + this.IBSBSGClass.MHIBSNameJavaCase + @"Service " + this.IBSBSGClass.MHIBSNameJavaCase + @"Service;");

            this.Src.AddLn(@"
	
	@RequestMapping(value=" + PP() + @"/add" + PP() + @", method=RequestMethod.GET)
	public ModelAndView add" + this.IBSBSGClass.MHIBSNameJavaCase + @"Page() {
");

            this.Src.AddLn(@"
		ModelAndView modelAndView = new ModelAndView(" + PP() + @"add-" + this.IBSBSGClass.MHIBSNameLowerCase + @"-form" + PP() + @");
		modelAndView.addObject(" + PP() + @"" + this.IBSBSGClass.MHIBSNameJavaCase + @"" + PP() + @", new " + this.IBSBSGClass.MHIBSNameJavaCase + @"());
");

            this.Src.AddLn(@"	
        return modelAndView;
	}");

            this.Src.AddLn(@"
	
	@RequestMapping(value=" + PP() + @"/add" + PP() + @", method=RequestMethod.POST)
	public ModelAndView adding" + this.IBSBSGClass.MHIBSNameJavaCase + @"(@ModelAttribute " + this.IBSBSGClass.MHIBSNameJavaCase + @" " + this.IBSBSGClass.MHIBSNameJavaCase + @") {
");

            this.Src.AddLn(@"		
		ModelAndView modelAndView = new ModelAndView(" + PP() + @"home" + PP() + @");
		" + this.IBSBSGClass.MHIBSNameJavaCase + @"Service.add" + this.IBSBSGClass.MHIBSNameJavaCase + @"(" + this.IBSBSGClass.MHIBSNameJavaCase + @");
		
		String message = " + PP() + @"" + this.IBSBSGClass.MHIBSNameJavaCase + @" was successfully added." + PP() + @";
		modelAndView.addObject(" + PP() + @"message" + PP() + @", message);
");

            this.Src.AddLn(@"		
		return modelAndView;
	}
");

            this.Src.AddLn(@"	
	@RequestMapping(value=" + PP() + @"/list" + PP() + @")
	public ModelAndView listOf" + this.IBSBSGClass.MHIBSNameJavaCase + @"s() {");

            this.Src.AddLn(@"
		ModelAndView modelAndView = new ModelAndView(" + PP() + @"list-of-" + this.IBSBSGClass.MHIBSNameLowerCase + @"s" + PP() + @");
");

            this.Src.AddLn(@"		
		List<" + this.IBSBSGClass.MHIBSNameJavaCase + @"> " + this.IBSBSGClass.MHIBSNameJavaCase + @"s = " + this.IBSBSGClass.MHIBSNameJavaCase + @"Service.get" + this.IBSBSGClass.MHIBSNameJavaCase + @"s();
		modelAndView.addObject(" + PP() + @"" + this.IBSBSGClass.MHIBSNameJavaCase + @"s" + PP() + @", " + this.IBSBSGClass.MHIBSNameJavaCase + @"s);
");

            this.Src.AddLn(@"		
		return modelAndView;
	}
");

            this.Src.AddLn(@"	
	@RequestMapping(value=" + PP() + @"/edit/{id}" + PP() + @", method=RequestMethod.GET)
	public ModelAndView edit" + this.IBSBSGClass.MHIBSNameJavaCase + @"Page(@PathVariable " + this.IBSBSGClass.GePrimaryType_Str() + @" id) {
");

            this.Src.AddLn(@"
		ModelAndView modelAndView = new ModelAndView(" + PP() + @"edit-" + this.IBSBSGClass.MHIBSNameLowerCase + @"-form" + PP() + @");
		" + this.IBSBSGClass.MHIBSNameJavaCase + @" " + this.IBSBSGClass.MHIBSNameJavaCase + @" = " + this.IBSBSGClass.MHIBSNameJavaCase + @"Service.get" + this.IBSBSGClass.MHIBSNameJavaCase + @"(id);
");

            this.Src.AddLn(@"
		modelAndView.addObject(" + PP() + @"" + this.IBSBSGClass.MHIBSNameJavaCase + @"" + PP() + @"," + this.IBSBSGClass.MHIBSNameJavaCase + @");
");

            this.Src.AddLn(@"
		return modelAndView;
	}
");

            this.Src.AddLn(@"	
	@RequestMapping(value=" + PP() + @"/edit/{id}" + PP() + @", method=RequestMethod.POST)
	public ModelAndView edditing" + this.IBSBSGClass.MHIBSNameJavaCase + @"(@ModelAttribute " + this.IBSBSGClass.MHIBSNameJavaCase + @" " + this.IBSBSGClass.MHIBSNameJavaCase + @", @PathVariable " + this.IBSBSGClass.GePrimaryType_Str() + @" id) {
		
		ModelAndView modelAndView = new ModelAndView(" + PP() + @"home" + PP() + @");
		
		" + this.IBSBSGClass.MHIBSNameJavaCase + @"Service.update" + this.IBSBSGClass.MHIBSNameJavaCase + @"(" + this.IBSBSGClass.MHIBSNameJavaCase + @");
		
		String message = " + PP() + @"" + this.IBSBSGClass.MHIBSNameJavaCase + @" was successfully edited." + PP() + @";
");

            this.Src.AddLn(@"
		modelAndView.addObject(" + PP() + @"message" + PP() + @", message);
		
		return modelAndView;
	}
");

            this.Src.AddLn(@"	
	@RequestMapping(value=" + PP() + @"/delete/{id}" + PP() + @", method=RequestMethod.GET)
	public ModelAndView delete" + this.IBSBSGClass.MHIBSNameJavaCase + @"(@PathVariable " + this.IBSBSGClass.GePrimaryType_Str() + @" id) {
		ModelAndView modelAndView = new ModelAndView(" + PP() + @"home" + PP() + @");
		" + this.IBSBSGClass.MHIBSNameJavaCase + @"Service.delete" + this.IBSBSGClass.MHIBSNameJavaCase + @"(id);
		String message = " + PP() + @"" + this.IBSBSGClass.MHIBSNameJavaCase + @" was successfully deleted." + PP() + @";
		modelAndView.addObject(" + PP() + @"message" + PP() + @", message);
		return modelAndView;
	}

}

");
		}

        public static string PP()
        {
            return @"""";
        }
		#endregion

	}
 
}