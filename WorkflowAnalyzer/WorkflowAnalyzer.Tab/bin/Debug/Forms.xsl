<?xml version="1.0"?>

<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                xmlns:i="http://schemas.datacontract.org/2004/07/Nintex.Forms"
                xmlns:d2p1="http://schemas.datacontract.org/2004/07/Nintex.Forms.FormControls">

  <xsl:template match="/">
    <html>
      <head>
        {Assets}
      </head>
      <body>
        <center>
          <h2>
            <div class="Title">
              <!--FormFileName PlaceHolder-->
            </div>
          </h2>
        </center>
        <xsl:apply-templates select="Form"/>
      </body>
    </html>
  </xsl:template>

  <xsl:template match="Form">
    <div class="Form">
      <xsl:apply-templates select="FormLayouts"/>
    </div>
  </xsl:template>

  <xsl:template match="FormLayout">
      <xsl:variable name="Width" select="Width"/>
      <xsl:variable name="BackgroundColor" select="BackgroundColor"/>
      <xsl:variable name="Height" select="Height"/>
      <div class="FormLayout" style="width:{$Width};background-color:{$BackgroundColor};height:{$Height};position:absolute;left:25%;">
        <div class="FormControlLayouts">
          <xsl:apply-templates select="FormControlLayouts"/>
        </div>
      </div>
  </xsl:template>

  <xsl:template match="FormControlLayout">
    <xsl:variable name="Width" select="Width"/>
    <xsl:variable name="BackgroundColor" select="BackgroundColor"/>
    <xsl:variable name="Height" select="Height"/>
    <xsl:variable name="Left" select="Left"/>
    <xsl:variable name="Top" select="Top"/>
    <xsl:variable name="ZIndex" select="ZIndex"/>
    <xsl:variable name="FormControlUniqueId" select="FormControlUniqueId"/>

    <xsl:for-each select="/Form/FormControls/FormControlProperties">

      <xsl:if test="UniqueId = $FormControlUniqueId">
        <xsl:variable name="BorderColor" select="BorderColor"/>
        <xsl:variable name="BorderStyle" select="BorderStyle"/>
        <xsl:variable name="BorderWidth" select="BorderWidth"/>
        <xsl:variable name="DisplayName" select="DisplayName"/>
        <xsl:variable name="ControlType" select="@type"/>
          
          <div class="FormControlLayout" style="width:{$Width};height:{$Height};Left:{$Left};Top:{$Top};float:left;z-index:{$ZIndex};position:absolute;border-color:{$BorderColor};border-style:{$BorderStyle};border-width:{$BorderWidth};background-color:white;background-image:url('nfimages/{$ControlType}.png');background-repeat:no-repeat;background-position:right top;">
            <b>
              <div class="ControlDisplayName" onclick="window.external.ShowConfig('{$FormControlUniqueId}')" style="cursor:pointer">
                <xsl:value-of select="@type"/>
              </div>
            </b>
            
            <br/>
            <!--<img src="nfimages/{$ControlType}.png"/>
            <br/>-->
            
            Display Name:
            <xsl:value-of select="DisplayName"/>
            <br/>
            
            <xsl:if test="Name != ''">
              Name:
              <xsl:value-of select="Name"/>
              <br/>
            </xsl:if>

            <xsl:if test="DataField != ''">
              Connected to:
              <xsl:value-of select="DataField"/>
              <br/>
            </xsl:if>
          </div>
        </xsl:if>

      </xsl:for-each>
      
    
    
  </xsl:template>
  
</xsl:stylesheet>