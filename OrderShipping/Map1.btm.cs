namespace OrderShipping {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"OrderShipping.Order", typeof(global::OrderShipping.Order))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"OrderShipping.FedExShipment", typeof(global::OrderShipping.FedExShipment))]
    public sealed class Map1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://OrderShipping.FedExShipment"" xmlns:s0=""http://OrderShipping.Order"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Order"" />
  </xsl:template>
  <xsl:template match=""/s0:Order"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(string(FirstName/text()) , &quot; &quot; , string(LastName/text()))"" />
    <ns0:FedExShipment>
      <Name>
        <xsl:value-of select=""$var:v1"" />
      </Name>
      <Address>
        <xsl:value-of select=""Address/text()"" />
      </Address>
    </ns0:FedExShipment>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"OrderShipping.Order";
        
        private const global::OrderShipping.Order _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"OrderShipping.FedExShipment";
        
        private const global::OrderShipping.FedExShipment _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"OrderShipping.Order";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"OrderShipping.FedExShipment";
                return _TrgSchemas;
            }
        }
    }
}
