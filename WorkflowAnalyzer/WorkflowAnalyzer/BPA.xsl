<?xml version="1.0"?>

<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:output method="html"/>
  <xsl:template match="/">
    
    <xsl:text disable-output-escaping="yes">&lt;!DOCTYPE&gt;</xsl:text>
    <html>
      <head>
        <xsl:text disable-output-escaping="yes">&lt;META http-equiv="X-UA-Compatible" content="IE=10"&gt;</xsl:text>
          <!--<style>
            BODY {
            font:x-small 'Verdana';
            margin-right:1.5em
            background-image: url('wfimages/logo.jpg');
            background-repeat:no-repeat;
            background-attachment:fixed;
            background-position:center;
            background-size: 50%;
            }
            .PassedCheck{
            border: 2px solid #323232;
            padding: 10px 40px;
            background: rgba(2,215,71,.5);
            width: 600px;
            border-radius: 25px;
            }
            .FailedCheck{
            border: 2px solid #323232;
            padding: 10px 40px;
            background: rgba(242,101,34,.5);
            width: 600px;
            border-radius: 25px;
            }
          </style>-->
        {Assets}
      </head>
      <body>
        <xsl:apply-templates select="/Checks"/>
      </body>
    </html>
  </xsl:template>

  <xsl:template match="//Check">
    <xsl:variable name="category" select="@Category"/>
    <xsl:choose>
      <xsl:when test="@Pass='true'">

        <div class="PassedCheck" category="{$category}">
          <div class="Name">
            <b>
              <xsl:value-of select="@Name"/>
            </b>
          </div>
            <br/>
            <br/>
          <div class="Url">
            <xsl:variable name="url" select="@Url"/>
            <a href="{$url}" target="_blank">
              <xsl:value-of select="@Url"/>
            </a>
          </div>
            <br/>
            <br/>
          <div class="Description">
            <xsl:value-of select="@Description"/>
          </div>
            <br/>
          <div class="Parameters">
            <div class="Parameter">
            <xsl:for-each select="node()">
              <xsl:value-of select="node()"/>
              <br/>
            </xsl:for-each>
            </div>
          </div>
        </div>
      </xsl:when>

      <xsl:otherwise>
        <div class="FailedCheck" category="{$category}">
          <div class="Name">
            <b>
              <xsl:value-of select="@Name"/>
            </b>
          </div>
          <br/>
          <br/>
          <div class="Url">
            <xsl:variable name="url" select="@Url"/>
            <a href="{$url}" target="_blank">
              <xsl:value-of select="@Url"/>
            </a>
          </div>
          <br/>
          <br/>
          <div class="Description">
            <xsl:value-of select="@Description"/>
          </div>
          <br/>
          <div class="Parameters">
            <div class="Parameter">
              <xsl:for-each select="node()">
                <xsl:value-of select="node()"/>
                <br/>
              </xsl:for-each>
            </div>
          </div>
        </div>
      </xsl:otherwise>
    </xsl:choose>
    <br/>
  </xsl:template>
  <xsl:template match="//Parameter">
    <div class="Parameter">
      <xsl:value-of select="node()"/>
    </div>
  </xsl:template>


</xsl:stylesheet>