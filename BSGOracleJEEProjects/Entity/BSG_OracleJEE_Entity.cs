

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


namespace BearcatSoft.BSGen.EngineF35.Generator.oraclejee_mvc.src.etp.vm.gen.entity
{	
	[GenerateANDCondition(new string[]{"GENER_LIB_DATAACCESS_DATAACCESS"})]
    [BSGTemplate(typeof(BSGClass)
        , SourceCodeType.Java_SourceCodeType
        , @"oraclejee-mvc\src\etp\vm\gen\entity")]
    public class BSG_OracleJEE_Entity : ProxyBaseClass
	{

        #region protected override Generate functions
		protected override void GenerateSourceForModel(BearcatSoft.BSGen.Framework.Components.CBSGModel.BSGModel item, BSGSourceFile src)
		{
        }
        #endregion

        #region GenerateSource
        protected override void GenerateSource(
            BSGClass item
            , BSGSourceFile src)
        {
            BearcatSoft.BSGen.Framework.Components.CBSGCLSType.BSGCLSType.BSGCLSType_Modified = "java";

            this.InitializeGenerator(
                item
                , src
                , ModelForGenerator);

            src.FileName = "" + this.IBSBSGClass.MHIBSNameJavaCase + @"";

            this.IBSBSGClass.SetChoosedDataSet_First();

            this.BSGEN_AddUsings();

            this.BSGEN_AddNamedQyeries();

            this.BSGEN_AddClassStart();

            this.BSGEN_AddFields();

            this.BSGEN_AddSetters();

            this.BSGEN_AddClassStop();
        }

        #endregion

        #region BSGEN_AddClassStop


        public void BSGEN_AddClassStop()
        {
            this.Src.AddLn(@"
}
");

        }
        #endregion

        #region BSGEN_AddClassStart

        public void BSGEN_AddClassStart()
        {
            this.Src.AddLn(@"
@Entity
@Table(name = " + PP() + this.IBSBSGClass.MHIBSName + PP() + @", catalog = " + PP() + this.IBSBSGClass.MHIBSName + PP() + @", schema = " + PP() + @"" + PP() + @", uniqueConstraints = {
@UniqueConstraint(columnNames = {" + PP() + @"name" + PP() + @"})})");

            this.Src.AddLn(@"
@XmlRootElement");

            this.Src.AddLn(@"public class " + this.IBSBSGClass.MHIBSNameJavaCase + @" implements Serializable 
{

");

        }
        #endregion

        #region BSGEN_AddNamedQyeries

        public void BSGEN_AddNamedQyeries()
        {
            this.Src.AddLn(@"
@NamedQueries({");

            this.Src.AddLn(@"
    @NamedQuery(name = " + PP() + @"Joo2Assets.findAll" + PP() + @", query = " + PP() + @"SELECT j FROM Joo2Assets j" + PP() + @"),
    @NamedQuery(name = " + PP() + @"Joo2Assets.findById" + PP() + @", query = " + PP() + @"SELECT j FROM Joo2Assets j WHERE j.id = :id" + PP() + @"),
    @NamedQuery(name = " + PP() + @"Joo2Assets.findByParentId" + PP() + @", query = " + PP() + @"SELECT j FROM Joo2Assets j WHERE j.parentId = :parentId" + PP() + @"),
    @NamedQuery(name = " + PP() + @"Joo2Assets.findByLft" + PP() + @", query = " + PP() + @"SELECT j FROM Joo2Assets j WHERE j.lft = :lft" + PP() + @"),
    @NamedQuery(name = " + PP() + @"Joo2Assets.findByRgt" + PP() + @", query = " + PP() + @"SELECT j FROM Joo2Assets j WHERE j.rgt = :rgt" + PP() + @"),
    @NamedQuery(name = " + PP() + @"Joo2Assets.findByLevel" + PP() + @", query = " + PP() + @"SELECT j FROM Joo2Assets j WHERE j.level = :level" + PP() + @"),
    @NamedQuery(name = " + PP() + @"Joo2Assets.findByName" + PP() + @", query = " + PP() + @"SELECT j FROM Joo2Assets j WHERE j.name = :name" + PP() + @"),
    @NamedQuery(name = " + PP() + @"Joo2Assets.findByTitle" + PP() + @", query = " + PP() + @"SELECT j FROM Joo2Assets j WHERE j.title = :title" + PP() + @"),
    @NamedQuery(name = " + PP() + @"Joo2Assets.findByRules" + PP() + @", query = " + PP() + @"SELECT j FROM Joo2Assets j WHERE j.rules = :rules" + PP() + @")})
");

        }
                #endregion

        #region BSGEN_AddUsings

        public void BSGEN_AddUsings()
        {
            this.Src.AddLn(@"

package etp.vm.gen.entity;
import java.io.Serializable;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.Table;
import javax.persistence.UniqueConstraint;
import javax.validation.constraints.NotNull;
import javax.validation.constraints.Size;
import javax.xml.bind.annotation.XmlRootElement;

");

        }
                #endregion

        #region BSGEN_AddFields

        public void BSGEN_AddFields()
        {
            int ii = 0;
            foreach (BSGFieldItem dd_fi in this.IBSBSGClass.MHIBSChoosedDataSet.ClassFields)
            {

                string c_type_converted = dd_fi.PBSGFINetType.PBSGNTCLSType.BSGCLSType_ClsTypeConverted();
                string c_type_not_converted = dd_fi.PBSGFINetType.PBSGNTCLSType.ClsType;
                if (ii == 0)
                {
                    this.BSGEN_AddPrimary(
                        dd_fi
                        , c_type_converted);


                }
                else
                {

                    this.BSGEN_AddNotPrimary(
                        dd_fi
                        , c_type_converted
                        , c_type_not_converted);


                }
                ii++;

            }

        }
        #endregion

        #region BSGEN_AddNotPrimary

        public void BSGEN_AddNotPrimary(
            BSGFieldItem dd_fi
            , string c_type_converted
            , string c_type_not_converted)
        {

            if (c_type_not_converted == "java.util.Date"
                || c_type_not_converted == "Date"
                || c_type_not_converted == "DateTime")
            {

                this.BSGEN_AddDateTime(    
                    dd_fi    
                    , c_type_converted    
                    , c_type_not_converted);
            }
            else
            {
                this.BSGEN_AddNotDateTime(
                    dd_fi
                    , c_type_converted
                    , c_type_not_converted);

            }

            this.Src.AddLn(@"    private " + c_type_converted + " " + dd_fi.Name + @";");

        }
        #endregion

        #region BSGEN_AddNotDateTime
        public void BSGEN_AddNotDateTime(
            BSGFieldItem dd_fi
            , string c_type_converted
            , string c_type_not_converted)
        {
            this.Src.AddLn(@"                        
    @GeneratedValue
    @Column(name=" + PP() + dd_fi.PBSGFieldItemSql.SqlOriginalName + PP() + @")");

        }
        #endregion

        #region BSGEN_AddDateTime
        public void BSGEN_AddDateTime(
            BSGFieldItem dd_fi
            , string c_type_converted
            , string c_type_not_converted)
        {
            bool to_dt = false;

            if (to_dt)
            {
                this.Src.AddLn(@"
                                @Basic(optional = false)");

                this.Src.AddLn(@"
    @Column(name = " + PP() + dd_fi.PBSGFieldItemSql.SqlOriginalName + PP() + @", columnDefinition=" + PP() + @"DATETIME" + PP() + @")
    @Temporal(TemporalType.TIMESTAMP)");

            }
            else
            {

                this.Src.AddLn(@"
    @GeneratedValue
    @Column(name = " + PP() + dd_fi.PBSGFieldItemSql.SqlOriginalName + PP() + @", columnDefinition=" + PP() + @"VARCHAR" + PP() + @")");
            }

        }

        public void BSGEN_AddPrimary(BSGFieldItem dd_fi,string c_type_converted)
        {
            this.Src.AddLn(@"


    @Id
    @GeneratedValue
    @Column(name=" + PP() + dd_fi.PBSGFieldItemSql.SqlOriginalName + PP() + @")
    private " + c_type_converted + " " + dd_fi.Name + @";");

        }

        public void BSGEN_AddSetters()
        {
            foreach (BSGFieldItem dd_fi in this.IBSBSGClass.MHIBSChoosedDataSet.ClassFields)
            {

                string c_type = dd_fi.PBSGFINetType.PBSGNTCLSType.BSGCLSType_ClsTypeConverted();

                this.Src.AddLn(@"
	public " + c_type + @" get" + dd_fi.Name + @"() {
		return " + dd_fi.Name + @";
	}
");

                this.Src.AddLn(@"

	public void set" + dd_fi.Name + @"(" + c_type + " " + dd_fi.Name + @") {");

                this.Src.AddLn(@"
		this." + dd_fi.Name + @" = " + dd_fi.Name + @";
	}");
            }

        }
        public static string PP()
        {
            return @"""";
        }
		#endregion

	}
 
}
