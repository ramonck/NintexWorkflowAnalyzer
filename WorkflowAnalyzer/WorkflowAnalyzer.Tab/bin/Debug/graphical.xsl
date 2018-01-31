<?xml version="1.0"?>

<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:output method="html"/>

  <xsl:template match="/ExportedWorkflow">
    <html>
      <head>
        <style>
          body{
          background-image: url('wfimages/logo.jpg');
          background-repeat:no-repeat;
          background-attachment:fixed;
          background-position:center;
          background-size: 50%;
          }
          Table{
          border-style: solid;
          border-width: 1px;
          border-color: gray;
          }
          th{
          border-style: dotted;
          border-width: 1px;
          border-color: gray;
          vertical-align:top;
          }
          .nwactionconfig{
          }

        </style>

        <script>

          function onclickExpandNWAction(nwactionconfigID) {
          if (typeof document.getElementById(nwactionconfigID).toggle === 'undefined'){
          document.getElementById(nwactionconfigID).style.display = "block";
          document.getElementById(nwactionconfigID).toggle = "enabled";
          }
          else{
          document.getElementById(nwactionconfigID).style.display = "none";
          document.getElementById(nwactionconfigID).toggle = undefined;
          }
          }
          function onclickCloseNWAction(nwactionconfigID) {
          document.getElementById(nwactionconfigID).style.display = "none";
          }
          function setActionsSideBySide(nwactionconfigID) {
          document.getElementById(nwactionconfigID).style.float = "left";
          alert("test");
          }
        </script>
      </head>
      <body>
        <!--Workflow Header information-->
        <center>
          <div class="ExportedWorkflow">
            <div class="Title">
              <h2>
                <xsl:value-of select="Title"/>
              </h2>
            </div>
            <div class="Description">
              <xsl:value-of select="Description"/>
            </div>
          </div>
          <div class="Workspace">
            <center>
              <xsl:apply-templates select="Configurations/ActionConfigs/NWActionConfig"/>
            </center>
          </div>
          <br/>
          <img src="wfimages/EndWorkflowMarker.png"/>
        </center>
      </body>
    </html>
  </xsl:template>
  <xsl:template match="NWActionConfig" name="NWActionConfig">
    <div class="NWActionConfig">
      <center>
        <xsl:choose>
          <xsl:when test="Enabled='false'">
            <div class="ActionTitle" style="color:gray;">
              <b>
                <xsl:apply-templates select="TLabel"/>
              </b>
            </div>
          </xsl:when>
          <xsl:otherwise>
            <div class="ActionTitle">
              <b>
                <xsl:apply-templates select="TLabel"/>
              </b>
            </div>
          </xsl:otherwise>
        </xsl:choose>
        <!--Checking for disabled actions-->
        <xsl:choose>
          <xsl:when test="not(contains(Type, 'Nintex.Workflow.'))">
            <div class="ActionIcon">
              <xsl:variable name="assemblyname" select="Type"/>

              <img src="wfimages/CustomAction.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:red;"/>

              <div class="nwactionconfig" id="nwchild_{generate-id()}" style="display:none;text-align:left">
                <br/>
                <b>
                  <xsl:text>Assembly Name: </xsl:text>
                </b>
                <xsl:value-of select="Type"/>
                <br/>
                <b>
                  <xsl:text>Expected Duration: </xsl:text>
                </b>
                <xsl:value-of select="ExpectedDuration"/>
                <br/>
                <b>
                  <xsl:text>Enabled: </xsl:text>
                </b>
                <xsl:value-of select="Enabled"/>
                <br/>
                <hr/>
                <br/>
                <b>
                  <xsl:text>Parameters</xsl:text>
                </b>
                <br/>
                <xsl:for-each select="Parameters/*">
                  <b>
                    <xsl:text>Parameter Name: </xsl:text>
                  </b>
                  <xsl:value-of select="@Name"/>
                  <br/>
                  <b>
                    <xsl:text>Value: </xsl:text>
                  </b>
                  <xsl:value-of select="PrimitiveValue/@Value"/>
                  <br/>
                </xsl:for-each>
                <br/>
              </div>
            </div>


          </xsl:when>
          <xsl:otherwise>
            <div class="ActionIcon">
              <xsl:variable name="assemblyname" select="Type"/>

              <!--Batching Check-->
              <xsl:choose>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWAddUserToADGroupAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.SPUndoCheckOutItemAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWCheckInItemAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWCheckInItemAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWCheckInItemWithKeyAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.SPCheckOutItemAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.SPCheckOutItemWithKeyAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWCompleteNWTaskAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWConvertDocumentAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.SPCopyItemAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.SPCopyItemWithKeyAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWCopyToFolderAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWCopyToSharepointSiteAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWCopyToSharepointSite2Adapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWCreateADSecurityGroupAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWCreateADAccountAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWCreateItemWithContentTypesAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWExchangeCreateAppointmentAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWCreateAudienceAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWCreateCRMEntityRecordAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWCreateItemWithContentTypesAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWCreateSiteSpecificItemAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWCreateListAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWCreateList2Adapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWCreateWebAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWCreateWeb2Adapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWCreateSiteCollectionAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWExchangeCreateTaskAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.SPDeclareRecordAdaptor'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWDecommissionUserAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWDeleteSiteCollectionAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWDeleteADSecurityGroupAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.SPDeleteItemAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWDeleteAudienceAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.SPDeleteDraftsAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.SPDeleteItemWithKeyAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWDeleteMultipleItemAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.SPDeletePreviousVersionsAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWDeleteWebAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWDeleteWeb2Adapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWDeleteCRMEntitiesAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.SPUndoCheckOutItemWithKeyAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWEnableLCSOnADAccountAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <!--<xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWWriteToHistoryListAdapter'">
                                    <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                                </xsl:when>-->
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWSetModerationStatusAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.SPSetContentApprovalStatusForDocumentSetAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.SPSetCustomWorkflowStatusAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.SPUndeclareRecordAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWUpdateADAccountAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.SPUpdateItemAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.SPUpdateItemAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWUpdateCRMRecordAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWUpdateDocumentAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.SPUpdateItemWithKeyAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWUpdateMultipleItemAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWUpdateUserProfileAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWUpdateXmlAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.SPWaitForAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.SPWaitForWithKeyAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.NWSetItemPermissions'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.SPSetFieldAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:when test="$assemblyname='Nintex.Workflow.Activities.Adapters.SPSetFieldWithKeyAdapter'">
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id}" onclick="onclickExpandNWAction(this.nextSibling.id)" style="background-color:orange;"/>
                </xsl:when>
                <xsl:otherwise>
                  <img src="wfimages/{$assemblyname}.png" id="{generate-id()}" onclick="onclickExpandNWAction(this.nextSibling.id)"/>
                </xsl:otherwise>
              </xsl:choose>
              
              <!--Main Action template-->
              <div class="nwactionconfig" id="nwchild_{generate-id()}" style="display:none;text-align:left">
                <br/>

                <b>
                  <xsl:text>Hide UI: </xsl:text>
                </b>
                <xsl:value-of select="HideUI"/>
                <br/>
                
                <b>
                  <xsl:text>Enabled: </xsl:text>
                </b>
                <xsl:value-of select="Enabled"/>
                <br/>

                <b>
                  <xsl:text>Inhertied Enabled: </xsl:text>
                </b>
                <xsl:value-of select="InheritedEnabled"/>
                <br/>

                <xsl:if test="BLabel != ''">
                  <b>
                    <xsl:text>Bottom Label: </xsl:text>
                  </b>
                  <xsl:value-of select="BLabel"/>
                  <br/>
                </xsl:if>

                <xsl:if test="LLabel != ''">
                  <b>
                    <xsl:text>Left Label: </xsl:text>
                  </b>
                  <xsl:value-of select="LLabel"/>
                  <br/>
                </xsl:if>

                <xsl:if test="RLabel != ''">
                  <b>
                    <xsl:text>Right Label: </xsl:text>
                  </b>
                  <xsl:value-of select="RLabel"/>
                  <br/>
                </xsl:if>

                <xsl:if test="TLabel != ''">
                  <b>
                    <xsl:text>Top Label: </xsl:text>
                  </b>
                  <xsl:value-of select="TLabel"/>
                  <br/>
                </xsl:if>

                <xsl:if test="CustomComments != ''">
                  <b>
                    <xsl:text>Custom Comments: </xsl:text>
                  </b>
                  <xsl:value-of select="CustomComments"/>
                  <br/>
                </xsl:if>
                
                <b>
                  <xsl:text>Expected Duration: </xsl:text>
                </b>
                <xsl:value-of select="ExpectedDuration"/>
                <br/>

                <b>
                  <xsl:text>Assembly: </xsl:text>
                </b>
                <xsl:value-of select="Assembly"/>
                <br/>
                
                <b>
                  <xsl:text>Type: </xsl:text>
                </b>
                <xsl:value-of select="Type"/>
                <br/>
                
                <b>
                  <xsl:text>Valid: </xsl:text>
                </b>
                <xsl:value-of select="IsValid"/>
                <br/>

                <b>
                  <xsl:text>Condition Use: </xsl:text>
                </b>
                <xsl:value-of select="ConditionUse"/>
                <br/>

                <xsl:if test="LogMessage">
                  <b>
                    <xsl:text>Log Message: </xsl:text>
                  </b>
                  <xsl:value-of select="LogMessage"/>
                  <br/>
                </xsl:if>

                <xsl:if test="HistoryNote != ''">
                  <b>
                    <xsl:text>History Note: </xsl:text>
                  </b>
                  <xsl:value-of select="HistoryNote"/>
                  <br/>
                </xsl:if>

                <xsl:if test="HasDefaultMessage">
                  <b>
                    <xsl:text>Has Default Message: </xsl:text>
                  </b>
                  <xsl:value-of select="HasDefaultMessage"/>
                  <br/>
                </xsl:if>

                <xsl:if test="Differentiator">
                  <b>
                    <xsl:text>Differentiator: </xsl:text>
                  </b>
                  <xsl:value-of select="Differentiator"/>
                  <br/>
                </xsl:if>

                <xsl:if test="UserContext">
                  <b>
                    <xsl:text>User Context: </xsl:text>
                  </b>
                  <xsl:value-of select="UserContext"/>
                  <br/>
                </xsl:if>

                <xsl:if test="SelectedUserContext">
                  <b>
                    <xsl:text>Selected User Context: </xsl:text>
                  </b>
                  <xsl:value-of select="SelectedUserContext"/>
                  <br/>
                </xsl:if>
                
                <hr/>
                <br/>
                <!--Parameter Handling-->
                <xsl:if test="Parameters">
                <b>
                  <xsl:text>Parameters</xsl:text>
                </b>             
                <xsl:for-each select="Parameters/*">
                  <br/>
                  <div class="actionparameter" id="actionparameter_{generate-id()}" style="border-style:solid;border-width:1px;border-color:gray;padding:10px">

                    <xsl:if test="@DisplayName !=''"> 
                  <b>
                    <xsl:text>Display Name: </xsl:text>
                  </b>
                  <xsl:value-of select="@DisplayName"/>
                  
                  <br/>
                  </xsl:if>
                    
                    <xsl:if test="@Name !=''">
                      <b>
                        <xsl:text>Name: </xsl:text>
                      </b>
                      <xsl:value-of select="@Name"/>
                      <br/>
                    </xsl:if>
                    
                  <!--if PrimitiveValue/@Value exists-->
                  <xsl:if test="PrimitiveValue/@Value">
                    <br/>
                    <b>
                    <xsl:text>PrimitiveValue</xsl:text>
                    </b>
                    <div class="actionPrimitiveValue" id="actionPrimitiveValue_{generate-id()}" style="border-style:solid;border-width:1px;border-color:gray;padding:10px">
                      <xsl:if test="PrimitiveValue/@Value !=''">
                        <b>
                          <xsl:text>PrimitiveValue: </xsl:text>
                        </b>
                        <xsl:value-of select="PrimitiveValue/@Value"/>
                        <br/>
                      </xsl:if>
                      <b>
                        <xsl:text>Value Type: </xsl:text>
                      </b>
                      <xsl:value-of select="PrimitiveValue/@ValueType"/>
                      <br/>
                    </div>
                  </xsl:if>
                    
                  <!--if WorkflowConstant exists-->
                  <xsl:if test="WorkflowConstant">
                    <br/>
                    <b>
                    <xsl:text>WorkflowConstant</xsl:text>
                    </b>
                    <div class="actionWorkflowConstant" id="actionWorkflowConstant_{generate-id()}" style="border-style:solid;border-width:1px;border-color:gray;padding:10px">
                      <xsl:if test="WorkflowConstant/@Name !=''">
                        <b>
                          <xsl:text>Name: </xsl:text>
                        </b>
                        <xsl:value-of select="WorkflowConstant/@Name"/>
                        <br/>
                      </xsl:if>
                      <b>
                        <xsl:text>Type: </xsl:text>
                      </b>
                      <xsl:value-of select="WorkflowConstant/@Type"/>
                      <br/>
                    </div>
                  </xsl:if>
                    
                  <!--if Coercion exists-->
                  <xsl:if test="Coercion">
                    <br/>
                    <b>
                    <xsl:text>Coercion</xsl:text>
                    </b>
                    <div class="actionCoercion" id="actionCoercion_{generate-id()}" style="border-style:solid;border-width:1px;border-color:gray;padding:10px">
                      <xsl:if test="Coercion !=''">
                        <!--<b>
                          <xsl:text>Coercion: </xsl:text>
                        </b>-->
                        <xsl:value-of select="Coercion"/>
                        <br/>
                      </xsl:if>
                    </div>
                  </xsl:if>

                  <!--if Variable/@Name exists-->
                  <xsl:if test="Variable/@Name">
                    <br/>
                    <b>
                      <xsl:text>Variable</xsl:text>
                    </b>
                    <div class="actionVariablee" id="actionVariable_{generate-id()}" style="border-style:solid;border-width:1px;border-color:gray;padding:10px">
                      <b>
                        <xsl:text>Variable Name: </xsl:text>
                      </b>
                      <xsl:value-of select="Variable/@Name"/>
                      <br/>
                      <b>
                        <xsl:text>Required: </xsl:text>
                      </b>
                      <xsl:value-of select="Variable/@Required"/>
                      <br/>
                      <b>
                        <xsl:text>StartupOptionsConfigured: </xsl:text>
                      </b>
                      <xsl:value-of select="Variable/@StartupOptionsConfigured"/>
                      <br/>
                      <b>
                        <xsl:text>ControlType: </xsl:text>
                      </b>
                      <xsl:value-of select="Variable/@ControlType"/>
                      <br/>
                      <b>
                        <xsl:text>Type: </xsl:text>
                      </b>
                      <xsl:value-of select="Variable/@Type"/>
                      <br/>
                      <b>
                        <xsl:text>Initiate: </xsl:text>
                      </b>
                      <xsl:value-of select="Variable/@Initiate"/>
                      <br/>
                      <b>
                        <xsl:text>Description: </xsl:text>
                      </b>
                      <xsl:value-of select="Variable/@Description"/>
                      <br/>
                      <b>
                        <xsl:text>Direction: </xsl:text>
                      </b>
                      <xsl:value-of select="Variable/@Direction"/>
                      <br/>
                    </div>
                  </xsl:if>

                  <!--if RunNowOPtions exists-->
                  <xsl:if test="RunNowOptions">
                    <br/>
                    <b>
                      <xsl:text>Run Now Options</xsl:text>
                    </b>
                    <div class="actionRunNowOptions" id="actionRunNowOptions_{generate-id()}" style="border-style:solid;border-width:1px;border-color:gray;padding:10px">
                      <b>
                        <xsl:text>Display Index: </xsl:text>
                      </b>
                      <xsl:value-of select="RunNowOptions/@DisplayIndex"/>
                      <br/>
                      <b>
                        <xsl:text>Control Type: </xsl:text>
                      </b>
                      <xsl:value-of select="RunNowOptions/@ControlType"/>
                      <br/>
                      <b>
                        <xsl:text>Required: </xsl:text>
                      </b>
                      <xsl:value-of select="RunNowOptions/@Required"/>
                      <br/>
                      <b>
                        <xsl:text>Group With Previous: </xsl:text>
                      </b>
                      <xsl:value-of select="RunNowOptions/@GroupWithPrevious"/>
                      <br/>
                    </div>
                  </xsl:if>
                  </div>
                  <br/>
                </xsl:for-each>
                
                </xsl:if>
                <!--End Parameter Handling-->
                
                <!--FieldReferences Handling-->
                <xsl:if test="FieldReferences">
                  <b>
                    <xsl:text>Field References</xsl:text>
                  </b>

                  <xsl:for-each select="FieldReferences/*">
                    <br/>
                    <div class="actionparameter" id="actionparameter_{generate-id()}" style="border-style:solid;border-width:1px;border-color:gray;padding:10px">

                      <xsl:if test="@Name !=''">
                        <b>
                          <xsl:text>Name: </xsl:text>
                        </b>
                        <xsl:value-of select="@Name"/>
                        <br/>
                      </xsl:if>

                      <xsl:if test="PrimitiveValue/@Value">
                        <br/>
                        
                        <b>
                          <xsl:text>PrimitiveValue</xsl:text>
                        </b>
                        <div class="actionPrimitiveValue" id="actionPrimitiveValue_{generate-id()}" style="border-style:solid;border-width:1px;border-color:gray;padding:10px">

                          <b>
                            <xsl:text>Value: </xsl:text>
                          </b>
                          <xsl:value-of select="@Value"/>
                          <br/>

                          <b>
                            <xsl:text>Type: </xsl:text>
                          </b>
                          <xsl:value-of select="@Type"/>
                          <br/>

                          <b>
                            <xsl:text>Dirty: </xsl:text>
                          </b>
                          <xsl:value-of select="@Dirty"/>
                          <br/>

                          <b>
                            <xsl:text>InternalFieldName: </xsl:text>
                          </b>
                          <xsl:value-of select="@InternalFieldName"/>
                          <br/>

                          <b>
                            <xsl:text>PreserveFormatting: </xsl:text>
                          </b>
                          <xsl:value-of select="@PreserveFormatting"/>
                          <br/>
                          
                          <xsl:if test="PrimitiveValue/@Value !=''">
                            <b>
                              <xsl:text>PrimitiveValue: </xsl:text>
                            </b>
                            <xsl:value-of select="PrimitiveValue/@Value"/>
                            <br/>
                          </xsl:if>
                          
                          <b>
                            <xsl:text>Value Type: </xsl:text>
                          </b>
                          <xsl:value-of select="PrimitiveValue/@ValueType"/>
                          <br/>
                        </div>
                      </xsl:if>

                      <xsl:if test="Variable">
                        <br/>

                        <b>
                          <xsl:text>Variable</xsl:text>
                        </b>
                        <div class="actionVariable" id="actionVariable_{generate-id()}" style="border-style:solid;border-width:1px;border-color:gray;padding:10px">

                          <b>
                            <xsl:text>Value: </xsl:text>
                          </b>
                          <xsl:value-of select="@Value"/>
                          <br/>

                          <b>
                            <xsl:text>Type: </xsl:text>
                          </b>
                          <xsl:value-of select="@Type"/>
                          <br/>

                          <b>
                            <xsl:text>Dirty: </xsl:text>
                          </b>
                          <xsl:value-of select="@Dirty"/>
                          <br/>

                          <b>
                            <xsl:text>InternalFieldName: </xsl:text>
                          </b>
                          <xsl:value-of select="@InternalFieldName"/>
                          <br/>

                          <b>
                            <xsl:text>PreserveFormatting: </xsl:text>
                          </b>
                          <xsl:value-of select="@PreserveFormatting"/>
                          <br/>
                          
                          <b>
                            <xsl:text>Name: </xsl:text>
                          </b>
                            <xsl:value-of select="Variable/@Name"/>
                          <br/>

                          <b>
                            <xsl:text>Required: </xsl:text>
                          </b>
                          <xsl:value-of select="Variable/@Required"/>
                          <br/>

                          <b>
                            <xsl:text>StartupOptionsConfigured: </xsl:text>
                          </b>
                          <xsl:value-of select="Variable/@StartupOptionsConfigured"/>
                          <br/>

                          <b>
                            <xsl:text>ControlType: </xsl:text>
                          </b>
                          <xsl:value-of select="Variable/@ControlType"/>
                          <br/>

                          <b>
                            <xsl:text>Type: </xsl:text>
                          </b>
                          <xsl:value-of select="Variable/@Type"/>
                          <br/>

                          <b>
                            <xsl:text>Initiate: </xsl:text>
                          </b>
                          <xsl:value-of select="Variable/@Initiate"/>
                          <br/>

                          <b>
                            <xsl:text>Description: </xsl:text>
                          </b>
                          <xsl:value-of select="Variable/@Description"/>
                          <br/>

                          <b>
                            <xsl:text>Direction: </xsl:text>
                          </b>
                          <xsl:value-of select="Variable/@Direction"/>
                          <br/>

                          <b>
                            <xsl:text>RowIndex: </xsl:text>
                          </b>
                          <xsl:value-of select="Variable/@RowIndex"/>
                          <br/>
                        </div>
                      </xsl:if>
                      
                    </div>
                  </xsl:for-each>
                </xsl:if>
                <!--End FieldReferences Handling-->
                
                <!--Approver Handling-->
                <xsl:if test="Approvers">
                  <br/>
                  <b>
                    <xsl:text>Approvers</xsl:text>
                  </b>
                  <br/>
                  
                  <xsl:for-each select="Approvers/*">
                    <div class="actionapprovers" id="actionapprovers_{generate-id()}" style="border-style:solid;border-width:1px;border-color:gray;padding:10px">
                      <b>
                        <xsl:text>PrincipalType: </xsl:text>
                      </b>
                      <xsl:value-of select="@PrincipalType"/>
                      <b>
                        <br/>
                        <xsl:text>User: </xsl:text>
                      </b>
                      <xsl:value-of select="@User"/>
                      <br/>
                    </div>
                    <br/>
                  </xsl:for-each>
                  <br/>
                </xsl:if>
                <!--End Approver Handling-->
                
                <!--Message Handling-->
                <xsl:if test="Message">
                  <br/>
                  <b>
                    <xsl:text>Message</xsl:text>
                  </b>
                  <br/>
                  <!--Approver Handling-->
                    <div class="actionmessage" id="actionmessage_{generate-id()}" style="border-style:solid;border-width:1px;border-color:gray;padding:10px">
                      <b>
                        <xsl:text>Priority: </xsl:text>
                      </b>
                      <xsl:value-of select="Message/Priority"/>
                      <b>
                        <br/>
                        <xsl:text>Exclude Header And Footer: </xsl:text>
                      </b>
                      <xsl:value-of select="Message/ExcludeHeaderAndFooter"/>
                      <br/>
                      <b>
                      <xsl:text>Attachments: </xsl:text>
                      </b>
                      <xsl:value-of select="Message/Attachments"/>
                      <br/>
                      <b>
                        <xsl:text>Is Using Group Message: </xsl:text>
                      </b>
                      <xsl:value-of select="Message/IsUsingGroupMessage"/>
                      <br/>
                      <b>
                        <xsl:text>Allow Lazy Approve: </xsl:text>
                      </b>
                      <xsl:value-of select="Message/AllowLazyApprove"/>
                      <br/>
                      <b>
                        <xsl:text>Body (Rendered): </xsl:text> 
                      </b>
                      <div class="actionmessagefrom" id="actionmessagefrom_{generate-id()}" style="border-style:solid;border-width:1px;border-color:gray;padding:10px">
                        <xsl:value-of disable-output-escaping="yes" select="Message/Body"/>
                      </div>
                      <br/>
                      <b>
                        <xsl:text>Subject: </xsl:text>
                      </b>
                      <xsl:value-of select="Message/Subject"/>
                      <br/>
                      <b>
                        <xsl:text>Body (As HTML): </xsl:text>
                      </b>
                      <div class="actionmessagefrom" id="actionmessagefrom_{generate-id()}" style="border-style:solid;border-width:1px;border-color:gray;padding:10px">
                        <xsl:value-of select="Message/Body"/>
                      </div>
                      <br/>
                      <b>
                        <xsl:text>Subject: </xsl:text>
                      </b>
                      <xsl:value-of select="Message/Subject"/>
                      <br/>
                      <b>
                        <xsl:text>From: </xsl:text>
                      </b>
                      <div class="actionmessagefrom" id="actionmessagefrom_{generate-id()}" style="border-style:solid;border-width:1px;border-color:gray;padding:10px">
                        <b>
                          <xsl:text>Is Domain: </xsl:text>
                        </b>
                        <xsl:value-of select="Message/From/IsDomainGroup"/>
                        <br/>
                        <b>
                          <xsl:text>Is SPGroup: </xsl:text>
                        </b>
                        <xsl:value-of select="Message/From/IsSPGroup"/>
                        <br/>
                        <b>
                          <xsl:text>Is User: </xsl:text>
                        </b>
                        <xsl:value-of select="Message/From/IsUser"/>
                        <br/>
                      </div>
                      <br/>
                      <b>
                        <xsl:text>CcList: </xsl:text>
                      </b>
                      <xsl:value-of select="Message/CcList"/>
                      <br/>
                      <b>
                        <xsl:text>Attach File: </xsl:text>
                      </b>
                      <xsl:value-of select="Message/AttachFile"/>
                      <br/>
                      <b>
                        <xsl:text>Is Html Message: </xsl:text>
                      </b>
                      <xsl:value-of select="Message/IsHtmlMessage"/>
                      <br/>
                      <b>
                        <xsl:text>Delivery Type: </xsl:text>
                      </b>
                      <xsl:value-of select="Message/DeliveryType"/>
                      <br/>

                    </div>
                    <br/>
                  <!--End Approver Handling-->
                  <br/>
                </xsl:if>
                <!--End Message Handling-->

                <!--Outcome Handling-->
                <xsl:if test="Outcomes">
                  <xsl:if test="Outcome !=''">
                  <br/>
                  <b>
                    <xsl:text>Outcomes</xsl:text>
                  </b>
                  <br/>
                  <xsl:for-each select="Outcomes/*">
                    <div class="actionoutcomes" id="actionoutcomes_{generate-id()}" style="border-style:solid;border-width:1px;border-color:gray;padding:10px">
                      
                        <b>
                          <xsl:text>Outcome: </xsl:text>
                        </b>
                        <xsl:value-of select="Outcome"/>
                        <br/>
                      
                      </div>
                  </xsl:for-each>
                  </xsl:if>
                </xsl:if><!--should be corrected later on 4/15/2014-->
                <!--End Outcome Handling-->

                <!--AssociationColumns Handling-->
                <xsl:if test="AssociationColumns">
                  <xsl:if test="AssociationColumns !=''">
                    <br/>
                    <b>
                      <xsl:text>AssociationColumns</xsl:text>
                    </b>
                    <br/>
                    <xsl:for-each select="AssociationColumns/*">
                      <div class="actionAssociationColumns" id="actionAssociationColumns_{generate-id()}" style="border-style:solid;border-width:1px;border-color:gray;padding:10px">
                        <b>
                          <xsl:text>AssociationColumn: </xsl:text>
                        </b>
                        <xsl:value-of select="AssociationColumn"/>
                        <br/>
                      </div>
                    </xsl:for-each>
                  </xsl:if>
                </xsl:if><!--should be corrected later on 4/15/2014-->
                <!--End AssociationColumns Handling-->
                
              </div>
            </div>
          </xsl:otherwise>
        </xsl:choose>
        <div class="nwactionconfig" id="nwchild_{generate-id()}" style="display:none;text-align:left">
          <br/>
          <b>
            <xsl:text>Assembly Name: </xsl:text>
          </b>
          <xsl:value-of select="Type"/>
          <br/>
          <b>
            <xsl:text>Expected Duration: </xsl:text>
          </b>
          <xsl:value-of select="ExpectedDuration"/>
          <br/>
          <b>
            <xsl:text>Enabled: </xsl:text>
          </b>
          <xsl:value-of select="Enabled"/>
          <br/>
          <hr/>
          <br/>
          <b>
            <xsl:text>Parameters</xsl:text>
          </b>
          <br/>
          <xsl:for-each select="Parameters/*">
            <b>
              <xsl:text>Parameter Name: </xsl:text>
            </b>
            <xsl:value-of select="@Name"/>
            <br/>
            <b>
              <xsl:text>Value: </xsl:text>
            </b>
            <xsl:value-of select="PrimitiveValue/@Value"/>
            <br/>
          </xsl:for-each>
          <br/>
        </div>
      </center>
      <xsl:apply-templates select="ChildActivities/NWActionConfig"/>
    </div>
  </xsl:template>
  <xsl:template match="NWActionConfig[Type='Nintex.Workflow.Activities.Adapters.NWLoopAdapter']">
    <br/>
    <div class="NWActionConfigNWLoopAdapter">
      <center>
        <div class="ActionTitle">
          <br/>
          <b>
            <xsl:apply-templates select="TLabel"/>
          </b>
          <br/>
        </div>

        <div class="ActionIcon">
          <xsl:variable name="assemblyname" select="Type"/>
          <img src="wfimages/{$assemblyname}.png" id="{generate-id()}" onclick="onclickExpandNWAction(this.nextSibling.id)"/>
          <div class="nwactionconfig" id="nwchild_{generate-id()}" style="display:none;text-align:left">
            <br/>
            <b>
              <xsl:text>Assembly Name: </xsl:text>
            </b>
            <xsl:value-of select="Type"/>
            <br/>
            <b>
              <xsl:text>Expected Duration: </xsl:text>
            </b>
            <xsl:value-of select="ExpectedDuration"/>
            <br/>
            <b>
              <xsl:text>Enabled: </xsl:text>
            </b>
            <xsl:value-of select="Enabled"/>
            <br/>
            <hr/>
            <br/>
            <b>
              <xsl:text>Parameters</xsl:text>
            </b>
            <br/>
            <xsl:for-each select="Parameters/*">
              <b>
                <xsl:text>Parameter Name: </xsl:text>
              </b>
              <xsl:value-of select="@Name"/>
              <br/>
              <b>
                <xsl:text>Value: </xsl:text>
              </b>
              <xsl:value-of select="PrimitiveValue/@Value"/>
              <br/>
            </xsl:for-each>
            <br/>
          </div>
        </div>
      </center>
      <xsl:apply-templates select="ChildActivities/NWActionConfig"/>
      <br/>
    </div>
  </xsl:template>
  <xsl:template match="NWActionConfig[Type='Nintex.Workflow.Activities.Adapters.NWRunIf2Adapter']">
    <br/>
    <div class="NWActionConfigNWRunIf2Adapter">
      <center>
        <div class="ActionTitle">
          <br/>
          <b>
            <xsl:apply-templates select="TLabel"/>
          </b>
          <br/>
        </div>

        <div class="ActionIcon">
          <xsl:variable name="assemblyname" select="Type"/>
          <img src="wfimages/{$assemblyname}.png" id="{generate-id()}" onclick="onclickExpandNWAction(this.nextSibling.id)"/>
          <div class="nwactionconfig" id="nwchild_{generate-id()}" style="display:none;text-align:left">
            <br/>
            <b>
              <xsl:text>Assembly Name: </xsl:text>
            </b>
            <xsl:value-of select="Type"/>
            <br/>
            <b>
              <xsl:text>Expected Duration: </xsl:text>
            </b>
            <xsl:value-of select="ExpectedDuration"/>
            <br/>
            <b>
              <xsl:text>Enabled: </xsl:text>
            </b>
            <xsl:value-of select="Enabled"/>
            <br/>
            <hr/>
            <br/>
            <b>
              <xsl:text>Parameters</xsl:text>
            </b>
            <br/>
            <xsl:for-each select="Parameters/*">
              <b>
                <xsl:text>Parameter Name: </xsl:text>
              </b>
              <xsl:value-of select="@Name"/>
              <br/>
              <b>
                <xsl:text>Value: </xsl:text>
              </b>
              <xsl:value-of select="PrimitiveValue/@Value"/>
              <br/>
            </xsl:for-each>
            <br/>
          </div>
        </div>
      </center>
      <table id="NWRunIf2AdapterTable">
        <xsl:for-each select="ChildActivities/NWActionConfig">
          <th id="NWRunIf2AdapterTH">
            <xsl:call-template name="NWActionConfig"/>
          </th>
        </xsl:for-each>
      </table>
      <br/>
    </div>
  </xsl:template>
  <xsl:template match="NWActionConfig[Type='Nintex.Workflow.Activities.Adapters.NWBusinessProcessAdapter']" name="NWBusinessProcessAdapter">
    <br/>
    <div class="NWActionConfigNWBusinessProcessAdapter">
      <center>
        <div class="ActionTitle">
          <br/>
          <b>
            <xsl:apply-templates select="TLabel"/>
          </b>
          <br/>
        </div>

        <div class="ActionIcon">
          <xsl:variable name="assemblyname" select="Type"/>
          <img src="wfimages/{$assemblyname}.png" id="{generate-id()}" onclick="onclickExpandNWAction(this.nextSibling.id)"/>
          <div class="nwactionconfig" id="nwchild_{generate-id()}" style="display:none;text-align:left">
            <br/>
            <b>
              <xsl:text>Assembly Name: </xsl:text>
            </b>
            <xsl:value-of select="Type"/>
            <br/>
            <b>
              <xsl:text>Expected Duration: </xsl:text>
            </b>
            <xsl:value-of select="ExpectedDuration"/>
            <br/>
            <b>
              <xsl:text>Enabled: </xsl:text>
            </b>
            <xsl:value-of select="Enabled"/>
            <br/>
            <hr/>
            <br/>
            <b>
              <xsl:text>Parameters</xsl:text>
            </b>
            <br/>
            <xsl:for-each select="Parameters/*">
              <b>
                <xsl:text>Parameter Name: </xsl:text>
              </b>
              <xsl:value-of select="@Name"/>
              <br/>
              <b>
                <xsl:text>Value: </xsl:text>
              </b>
              <xsl:value-of select="PrimitiveValue/@Value"/>
              <br/>
            </xsl:for-each>
            <br/>
          </div>
        </div>
      </center>
      <table id="NWBusinessProcessAdapterTable">
        <xsl:for-each select="ChildActivities/NWActionConfig">
          <th id="NWBusinessProcessAdapterTH">
            <xsl:call-template name="NWActionConfig"/>
          </th>
        </xsl:for-each>
      </table>
      <br/>
    </div>
  </xsl:template>
  <xsl:template match="NWActionConfig[Type='Nintex.Workflow.Activities.Adapters.NWLoopAdapter']" name="NWLoopAdapter">
    <br/>
    <div class="NWActionConfigNWLoopAdapter">
      <center>
        <div class="ActionTitle">
          <br/>
          <b>
            <xsl:apply-templates select="TLabel"/>
          </b>
          <br/>
        </div>

        <div class="ActionIcon">
          <xsl:variable name="assemblyname" select="Type"/>
          <img src="wfimages/{$assemblyname}.png" id="{generate-id()}" onclick="onclickExpandNWAction(this.nextSibling.id)"/>
          <div class="nwactionconfig" id="nwchild_{generate-id()}" style="display:none;text-align:left">
            <br/>
            <b>
              <xsl:text>Assembly Name: </xsl:text>
            </b>
            <xsl:value-of select="Type"/>
            <br/>
            <b>
              <xsl:text>Expected Duration: </xsl:text>
            </b>
            <xsl:value-of select="ExpectedDuration"/>
            <br/>
            <b>
              <xsl:text>Enabled: </xsl:text>
            </b>
            <xsl:value-of select="Enabled"/>
            <br/>
            <hr/>
            <br/>
            <b>
              <xsl:text>Parameters</xsl:text>
            </b>
            <br/>
            <xsl:for-each select="Parameters/*">
              <b>
                <xsl:text>Parameter Name: </xsl:text>
              </b>
              <xsl:value-of select="@Name"/>
              <br/>
                <b>
                  <xsl:text>Value: </xsl:text>
                </b>
                <xsl:value-of select="PrimitiveValue/@Value"/>
                <br/>
            </xsl:for-each>
            <br/>
          </div>
        </div>
      </center>
      <table id="NWLoopAdapterTable">
        <xsl:for-each select="ChildActivities/NWActionConfig">
          <th id="NWLoopAdapterTH">
            <xsl:call-template name="NWActionConfig"/>
          </th>
        </xsl:for-each>
      </table>
      <br/>
    </div>
  </xsl:template>
  <xsl:template match="NWActionConfig[Type='Nintex.Workflow.Activities.Adapters.NWForEachLoopAdapter']">
    <br/>
    <div class="NWActionConfigNWForEachLoopAdapter">
      <center>
        <div class="ActionTitle">
          <br/>
          <b>
            <xsl:apply-templates select="TLabel"/>
          </b>
          <br/>
        </div>

        <div class="ActionIcon">
          <xsl:variable name="assemblyname" select="Type"/>
          <img src="wfimages/{$assemblyname}.png" id="{generate-id()}" onclick="onclickExpandNWAction(this.nextSibling.id)"/>
          <div class="nwactionconfig" id="nwchild_{generate-id()}" style="display:none;text-align:left">
            <br/>
            <b>
              <xsl:text>Assembly Name: </xsl:text>
            </b>
            <xsl:value-of select="Type"/>
            <br/>
            <b>
              <xsl:text>Expected Duration: </xsl:text>
            </b>
            <xsl:value-of select="ExpectedDuration"/>
            <br/>
            <b>
              <xsl:text>Enabled: </xsl:text>
            </b>
            <xsl:value-of select="Enabled"/>
            <br/>
            <hr/>
            <br/>
            <b>
              <xsl:text>Parameters</xsl:text>
            </b>
            <br/>
            <xsl:for-each select="Parameters/*">
              <b>
                <xsl:text>Parameter Name: </xsl:text>
              </b>
              <xsl:value-of select="@Name"/>
              <br/>
              <b>
                <xsl:text>Value: </xsl:text>
              </b>
              <xsl:value-of select="PrimitiveValue/@Value"/>
              <br/>
            </xsl:for-each>
            <br/>
          </div>
        </div>
      </center>
      <xsl:apply-templates select="ChildActivities/NWActionConfig"/>
      <br/>
    </div>
  </xsl:template>
  <xsl:template match="NWActionConfig[Type='Nintex.Workflow.Activities.Adapters.NWSwitchAdapter']" name="NWSwitchAdapter">
    <br/>
    <div class="NWActionConfigNWSwitchAdapter">
      <center>
        <div class="ActionTitle">
          <br/>
          <b>
            <xsl:apply-templates select="TLabel"/>
          </b>
          <br/>
        </div>

        <div class="ActionIcon">
          <xsl:variable name="assemblyname" select="Type"/>
          <img src="wfimages/{$assemblyname}.png" id="{generate-id()}" onclick="onclickExpandNWAction(this.nextSibling.id)"/>
          <div class="nwactionconfig" id="nwchild_{generate-id()}" style="display:none;text-align:left">
            <br/>
            <b>
              <xsl:text>Assembly Name: </xsl:text>
            </b>
            <xsl:value-of select="Type"/>
            <br/>
            <b>
              <xsl:text>Expected Duration: </xsl:text>
            </b>
            <xsl:value-of select="ExpectedDuration"/>
            <br/>
            <b>
              <xsl:text>Enabled: </xsl:text>
            </b>
            <xsl:value-of select="Enabled"/>
            <br/>
            <hr/>
            <br/>
            <b>
              <xsl:text>Parameters</xsl:text>
            </b>
            <br/>
            <xsl:for-each select="Parameters/*">
              <b>
                <xsl:text>Parameter Name: </xsl:text>
              </b>
              <xsl:value-of select="@Name"/>
              <br/>
              <b>
                <xsl:text>Value: </xsl:text>
              </b>
              <xsl:value-of select="PrimitiveValue/@Value"/>
              <br/>
            </xsl:for-each>
            <br/>
          </div>
        </div>
      </center>
      <table id="NWSwitchAdapterTable">
        <xsl:for-each select="ChildActivities/NWActionConfig">
          <th id="NWSwitchAdapterTH">
            <xsl:call-template name="NWSwitchBranchAdapter"/>
          </th>
        </xsl:for-each>
      </table>
    </div>
  </xsl:template>
  <xsl:template match="NWActionConfig[Type='Nintex.Workflow.Activities.Adapters.NWMultiOutcomeAdapter']" name="NWMultiOutcomeAdapter">
    <br/>
    <div class="NWActionConfigNWMultiOutcomeAdapter">
      <center>
        <div class="ActionTitle">
          <br/>
          <b>
            <xsl:apply-templates select="TLabel"/>
          </b>
          <br/>
        </div>

        <div class="ActionIcon">
          <xsl:variable name="assemblyname" select="Type"/>
          <img src="wfimages/{$assemblyname}.png" id="{generate-id()}" onclick="onclickExpandNWAction(this.nextSibling.id)"/>
          <div class="nwactionconfig" id="nwchild_{generate-id()}" style="display:none;text-align:left">
            <br/>
            <b>
              <xsl:text>Assembly Name: </xsl:text>
            </b>
            <xsl:value-of select="Type"/>
            <br/>
            <b>
              <xsl:text>Expected Duration: </xsl:text>
            </b>
            <xsl:value-of select="ExpectedDuration"/>
            <br/>
            <b>
              <xsl:text>Enabled: </xsl:text>
            </b>
            <xsl:value-of select="Enabled"/>
            <br/>
            <hr/>
            <br/>
            <b>
              <xsl:text>Parameters</xsl:text>
            </b>
            <br/>
            <xsl:for-each select="Parameters/*">
              <b>
                <xsl:text>Parameter Name: </xsl:text>
              </b>
              <xsl:value-of select="@Name"/>
              <br/>
              <b>
                <xsl:text>Value: </xsl:text>
              </b>
              <xsl:value-of select="PrimitiveValue/@Value"/>
              <br/>
            </xsl:for-each>
            <br/>
          </div>
        </div>
      </center>
      <table id="NWSwitchAdapterTable">
        <xsl:for-each select="ChildActivities/NWActionConfig">
          <th id="NWSwitchAdapterTH">
            <xsl:call-template name="NWSwitchBranchAdapter"/>
          </th>
        </xsl:for-each>
      </table>
    </div>
  </xsl:template>
  <xsl:template match="NWActionConfig[Type='Nintex.Workflow.Activities.Adapters.NWSwitchBranchAdapter']" name="NWSwitchBranchAdapter">
    <div class="NWActionConfigNWSwitchBranchAdapter">
      <center>
        <div class="ActionTitle">
          <br/>
          <xsl:value-of select="self::node()/Parameters/Parameter/PrimitiveValue/@Value"/>
          <br/>
        </div>

        <div class="ActionIcon">
          <xsl:variable name="assemblyname" select="Type"/>
          <img src="wfimages/{$assemblyname}.png" id="{generate-id()}" onclick="onclickExpandNWAction(this.nextSibling.id)"/>
          <div class="nwactionconfig" id="nwchild_{generate-id()}" style="display:none;text-align:left">
            <br/>
            <b>
              <xsl:text>Assembly Name: </xsl:text>
            </b>
            <xsl:value-of select="Type"/>
            <br/>
            <b>
              <xsl:text>Expected Duration: </xsl:text>
            </b>
            <xsl:value-of select="ExpectedDuration"/>
            <br/>
            <b>
              <xsl:text>Enabled: </xsl:text>
            </b>
            <xsl:value-of select="Enabled"/>
            <br/>
            <hr/>
            <br/>
            <b>
              <xsl:text>Parameters</xsl:text>
            </b>
            <br/>
            <xsl:for-each select="Parameters/*">
              <b>
                <xsl:text>Parameter Name: </xsl:text>
              </b>
              <xsl:value-of select="@Name"/>
              <br/>
              <b>
                <xsl:text>Value: </xsl:text>
              </b>
              <xsl:value-of select="PrimitiveValue/@Value"/>
              <br/>
            </xsl:for-each>
            <br/>
          </div>
        </div>
      </center>
      <xsl:apply-templates select="ChildActivities/NWActionConfig"/>
      <br/>
    </div>
    <xsl:text>&#160;</xsl:text>
  </xsl:template>
  <xsl:template match="NWActionConfig[Type='Nintex.Workflow.Activities.Adapters.WFSequenceAdapter']" name="WFSequenceAdapter">
    <div class="NWActionConfigWFSequenceAdapter">
      <xsl:apply-templates select="ChildActivities/NWActionConfig"/>
    </div>
  </xsl:template>
  <xsl:template match="NWActionConfig[Type='Nintex.Workflow.Activities.Adapters.NWStateMachine2Adapter']" name="NWStateMachine2Adapter">
    <br/>
    <div class="NWActionConfigNWStateMachine2Adapter">
      <center>
        <div class="ActionTitle">
          <br/>
          <b>
            <xsl:apply-templates select="TLabel"/>
          </b>
          <br/>
        </div>

        <div class="ActionIcon">
          <xsl:variable name="assemblyname" select="Type"/>
          <img src="wfimages/{$assemblyname}.png" id="{generate-id()}" onclick="onclickExpandNWAction(this.nextSibling.id)"/>
          <div class="nwactionconfig" id="nwchild_{generate-id()}" style="display:none;text-align:left">
            <br/>
            <b>
              <xsl:text>Assembly Name: </xsl:text>
            </b>
            <xsl:value-of select="Type"/>
            <br/>
            <b>
              <xsl:text>Expected Duration: </xsl:text>
            </b>
            <xsl:value-of select="ExpectedDuration"/>
            <br/>
            <b>
              <xsl:text>Enabled: </xsl:text>
            </b>
            <xsl:value-of select="Enabled"/>
            <br/>
            <hr/>
            <br/>
            <b>
              <xsl:text>Parameters</xsl:text>
            </b>
            <br/>
            <xsl:for-each select="Parameters/*">
              <b>
                <xsl:text>Parameter Name: </xsl:text>
              </b>
              <xsl:value-of select="@Name"/>
              <br/>
              <b>
                <xsl:text>Value: </xsl:text>
              </b>
              <xsl:value-of select="PrimitiveValue/@Value"/>
              <br/>
            </xsl:for-each>
            <br/>
          </div>
        </div>
      </center>
      <table>
        <xsl:for-each select="ChildActivities/NWActionConfig">
          <th>
            <xsl:call-template name="NWState2Adapter"/>
          </th>
        </xsl:for-each>
      </table>
      <br/>
    </div>
  </xsl:template>
  <xsl:template match="NWActionConfig[Type='Nintex.Workflow.Activities.Adapters.NWState2Adapter']" name="NWState2Adapter">
    <div class="NWActionConfigNWState2Adapter">
      <center>
        <div class="ActionTitle">
          <br/>
          <xsl:value-of select="self::node()/Parameters/Parameter/PrimitiveValue/@Value"/>
          <br/>
        </div>
      </center>
      <xsl:apply-templates select="ChildActivities/NWActionConfig"/>
      <br/>
    </div>
    <xsl:text>&#160;</xsl:text>
  </xsl:template>
  <xsl:template match="NWActionConfig[Type='Nintex.Workflow.Activities.Adapters.WFParallelAdapter']" name="WFParallelAdapter">
    <br/>
    <div class="NWActionConfigWFParallelAdapter">
      <center>
        <div class="ActionTitle">
          <br/>
          <b>
            <xsl:apply-templates select="TLabel"/>
          </b>
          <br/>
        </div>

        <div class="ActionIcon">
          <xsl:variable name="assemblyname" select="Type"/>
          <img src="wfimages/{$assemblyname}.png" id="{generate-id()}" onclick="onclickExpandNWAction(this.nextSibling.id)"/>
          <div class="nwactionconfig" id="nwchild_{generate-id()}" style="display:none;text-align:left">
            <br/>
            <b>
              <xsl:text>Assembly Name: </xsl:text>
            </b>
            <xsl:value-of select="Type"/>
            <br/>
            <b>
              <xsl:text>Expected Duration: </xsl:text>
            </b>
            <xsl:value-of select="ExpectedDuration"/>
            <br/>
            <b>
              <xsl:text>Enabled: </xsl:text>
            </b>
            <xsl:value-of select="Enabled"/>
            <br/>
            <hr/>
            <br/>
            <b>
              <xsl:text>Parameters</xsl:text>
            </b>
            <br/>
            <xsl:for-each select="Parameters/*">
              <b>
                <xsl:text>Parameter Name: </xsl:text>
              </b>
              <xsl:value-of select="@Name"/>
              <br/>
              <b>
                <xsl:text>Value: </xsl:text>
              </b>
              <xsl:value-of select="PrimitiveValue/@Value"/>
              <br/>
            </xsl:for-each>
            <br/>
          </div>
        </div>
      </center>
      <table id="WFParallelAdapterTable">
        <xsl:for-each select="ChildActivities/NWActionConfig">
          <th id="WFParallelAdapterTH">
            <xsl:call-template name="WFSequenceAdapter"/>
          </th>
        </xsl:for-each>
      </table>
    </div>
  </xsl:template>
  <xsl:template match="NWActionConfig[Type='Nintex.Workflow.Activities.Adapters.WFIfElseAdapter']" name="WFIfElseAdapter">
    <br/>
    <div class="NWActionConfigWFIfElseAdapter">
      <center>
        <div class="ActionTitle">
          <br/>
          <b>
            <xsl:apply-templates select="TLabel"/>
          </b>
          <br/>
        </div>

        <div class="ActionIcon">
          <xsl:variable name="assemblyname" select="Type"/>
          <img src="wfimages/{$assemblyname}.png" id="{generate-id()}" onclick="onclickExpandNWAction(this.nextSibling.id)"/>
          <div class="nwactionconfig" id="nwchild_{generate-id()}" style="display:none;text-align:left">
            <br/>
            <b>
              <xsl:text>Assembly Name: </xsl:text>
            </b>
            <xsl:value-of select="Type"/>
            <br/>
            <b>
              <xsl:text>Expected Duration: </xsl:text>
            </b>
            <xsl:value-of select="ExpectedDuration"/>
            <br/>
            <b>
              <xsl:text>Enabled: </xsl:text>
            </b>
            <xsl:value-of select="Enabled"/>
            <br/>
            <hr/>
            <br/>
            <b>
              <xsl:text>Parameters</xsl:text>
            </b>
            <br/>
            <xsl:for-each select="Parameters/*">
              <b>
                <xsl:text>Parameter Name: </xsl:text>
              </b>
              <xsl:value-of select="@Name"/>
              <br/>
              <b>
                <xsl:text>Value: </xsl:text>
              </b>
              <xsl:value-of select="PrimitiveValue/@Value"/>
              <br/>
            </xsl:for-each>
            <br/>
          </div>
        </div>
      </center>
      <table id="WFIfElseBranchAdapterTable">
        <xsl:for-each select="ChildActivities/NWActionConfig">
          <th id="WFIfElseBranchAdapterTH">
            <xsl:call-template name="WFIfElseBranchAdapter"/>
          </th>
        </xsl:for-each>
      </table>
    </div>
  </xsl:template>
  <xsl:template match="NWActionConfig[Type='Nintex.Workflow.Activities.Adapters.WFIfElseBranchAdapter']" name="WFIfElseBranchAdapter">
    <div class="NWActionConfigWFIfElseBranchAdapter">
      <center>
        <div class="ActionTitle">
          <br/>
          <xsl:value-of select="self::node()/Parameters/Parameter/PrimitiveValue/@Value"/>
          <br/>
        </div>

        <div class="ActionIcon">
          <xsl:variable name="assemblyname" select="Type"/>
          <img src="wfimages/Nintex.Workflow.Activities.Adapters.WFIfElseAdapter.png" width="20" height="20" id="{generate-id()}" onclick="onclickExpandNWAction(this.nextSibling.id)"/>
          <div class="nwactionconfig" id="nwchild_{generate-id()}" style="display:none;text-align:left">
            <br/>
            <b>
              <xsl:text>Assembly Name: </xsl:text>
            </b>
            <xsl:value-of select="Type"/>
            <br/>
            <b>
              <xsl:text>Expected Duration: </xsl:text>
            </b>
            <xsl:value-of select="ExpectedDuration"/>
            <br/>
            <b>
              <xsl:text>Enabled: </xsl:text>
            </b>
            <xsl:value-of select="Enabled"/>
            <br/>
            <hr/>
            <br/>
            <b>
              <xsl:text>Parameters</xsl:text>
            </b>
            <br/>
            <xsl:for-each select="Parameters/*">
              <b>
                <xsl:text>Parameter Name: </xsl:text>
              </b>
              <xsl:value-of select="@Name"/>
              <br/>
              <b>
                <xsl:text>Value: </xsl:text>
              </b>
              <xsl:value-of select="PrimitiveValue/@Value"/>
              <br/>
            </xsl:for-each>
            <br/>
          </div>
        </div>
      </center>
      <xsl:apply-templates select="ChildActivities/NWActionConfig"/>
      <br/>
    </div>
    <xsl:text>&#160;</xsl:text>
  </xsl:template>
  <xsl:template match="NWActionConfig[Type='Nintex.Workflow.Activities.Adapters.NWApproverAdapter']" name="NWApproverAdapter">
    <div class="NWActionConfigNWApproverAdapter">
      <center>
        <div class="ActionTitle">
          <br/>
          <xsl:value-of select="self::node()/Parameters/Parameter/PrimitiveValue/@Value"/>
          <br/>
        </div>

        <div class="ActionIcon">
          <xsl:variable name="assemblyname" select="Type"/>
          <img src="wfimages/{$assemblyname}.png" id="{generate-id()}" onclick="onclickExpandNWAction(this.nextSibling.id)"/>
          <div class="nwactionconfig" id="nwchild_{generate-id()}" style="display:none;text-align:left">
            <br/>
            <b>
              <xsl:text>Assembly Name: </xsl:text>
            </b>
            <xsl:value-of select="Type"/>
            <br/>
            <b>
              <xsl:text>Expected Duration: </xsl:text>
            </b>
            <xsl:value-of select="ExpectedDuration"/>
            <br/>
            <b>
              <xsl:text>Enabled: </xsl:text>
            </b>
            <xsl:value-of select="Enabled"/>
            <br/>
            <hr/>
            <br/>
            <b>
              <xsl:text>Parameters</xsl:text>
            </b>
            <br/>
            <xsl:for-each select="Parameters/*">
              <b>
                <xsl:text>Parameter Name: </xsl:text>
              </b>
              <xsl:value-of select="@Name"/>
              <br/>
              <b>
                <xsl:text>Value: </xsl:text>
              </b>
              <xsl:value-of select="PrimitiveValue/@Value"/>
              <br/>
            </xsl:for-each>
            <br/>
          </div>
        </div>
      </center>
      <table id="NWApproverBranchAdapterTable">
        <xsl:for-each select="ChildActivities/NWActionConfig">
          <th id="NWApproverBranchAdapterTH">
            <xsl:call-template name="NWApproverBranchAdapter"/>
          </th>
        </xsl:for-each>
      </table>
      <br/>
    </div>
    <xsl:text>&#160;</xsl:text>
  </xsl:template>
  <xsl:template match="NWActionConfig[Type='Nintex.Workflow.Activities.Adapters.NWApproverBranchAdapter']" name="NWApproverBranchAdapter">
    <div class="NWActionConfigNWApproverBranchAdapter">
      <center>
        <div class="ActionTitle">
          <br/>
          <xsl:value-of select="self::node()/Parameters/Parameter/PrimitiveValue/@Value"/>
          <br/>
        </div>

        <div class="ActionIcon">
          <div class="nwactionconfig" id="nwchild_{generate-id()}" style="display:none;text-align:left">
            <br/>
            <b>
              <xsl:text>Assembly Name: </xsl:text>
            </b>
            <xsl:value-of select="Type"/>
            <br/>
            <b>
              <xsl:text>Expected Duration: </xsl:text>
            </b>
            <xsl:value-of select="ExpectedDuration"/>
            <br/>
            <b>
              <xsl:text>Enabled: </xsl:text>
            </b>
            <xsl:value-of select="Enabled"/>
            <br/>
            <hr/>
            <br/>
            <b>
              <xsl:text>Parameters</xsl:text>
            </b>
            <br/>
            <xsl:for-each select="Parameters/*">
              <b>
                <xsl:text>Parameter Name: </xsl:text>
              </b>
              <xsl:value-of select="@Name"/>
              <br/>
              <b>
                <xsl:text>Value: </xsl:text>
              </b>
              <xsl:value-of select="PrimitiveValue/@Value"/>
              <br/>
            </xsl:for-each>
            <br/>
          </div>
        </div>
      </center>
      <xsl:apply-templates select="ChildActivities/NWActionConfig"/>
      <br/>
    </div>
    <xsl:text>&#160;</xsl:text>
  </xsl:template>

  <xsl:template match="TLabel">
    <xsl:value-of select="text()"/>
  </xsl:template>

</xsl:stylesheet>
