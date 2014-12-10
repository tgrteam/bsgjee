

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
    [BSGTemplate(typeof(BSGClass), SourceCodeType.Java_SourceCodeType, @"oraclejee-mvc\src\main\java\com\sprhib\dao\")]
    public class BSG_OracleJEE_DAO_Interface : ProxyBaseClass
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
            this.InitializeGenerator(
                item
                , src
                , ModelForGenerator);

            src.FileName = "" + this.IBSBSGClass.MHIBSNameJavaCase + @"DAO";

            this.IBSBSGClass.SetChoosedDataSet_First();
 
            this.Src.AddLn(@"
package com.sprhib.dao;

import java.util.List;

import com.sprhib.model." + this.IBSBSGClass.MHIBSNameJavaCase + @";

public interface " + this.IBSBSGClass.MHIBSNameJavaCase + @"DAO {
	
	public void add" + this.IBSBSGClass.MHIBSNameJavaCase + @"(" + this.IBSBSGClass.MHIBSNameJavaCase + @" " + this.IBSBSGClass.MHIBSNameJavaCase + @");
	public void update" + this.IBSBSGClass.MHIBSNameJavaCase + @"(" + this.IBSBSGClass.MHIBSNameJavaCase + @" " + this.IBSBSGClass.MHIBSNameJavaCase + @");
	public " + this.IBSBSGClass.MHIBSNameJavaCase + @" get" + this.IBSBSGClass.MHIBSNameJavaCase + @"(" + this.IBSBSGClass.GePrimaryType_Str() + @" id);
	public void delete" + this.IBSBSGClass.MHIBSNameJavaCase + @"(" + this.IBSBSGClass.GePrimaryType_Str() + @" id);
	public List<" + this.IBSBSGClass.MHIBSNameJavaCase + @"> get" + this.IBSBSGClass.MHIBSNameJavaCase + @"s();

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
