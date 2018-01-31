
using System.Collections.Generic;

namespace WorkflowAnalyzer
{

    /// <summary>
    /// Used to validate various conditions in plug-ins.
    /// </summary>
    public static class ValidationHelper
    {
        private static HashSet<string> _batchedActions;

        /// <summary>
        /// Batched action definitions based on adapter assembly names.
        /// </summary>
        public static HashSet<string> BatchedActions
        {
            get
            {
                if (_batchedActions == null) LoadBatchedActionHashSet();
                return _batchedActions;
            }
        } 

        /// <summary>
        /// Load batched action definitions into HashSet.
        /// </summary>
        /// <returns></returns>
        public static void LoadBatchedActionHashSet()
        {
            _batchedActions = new HashSet<string>();
            #region List of Actions
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWAddUserToADGroupAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.SPUndoCheckOutItemAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWCheckInItemAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWCheckInItemAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWCheckInItemWithKeyAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.SPCheckOutItemAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.SPCheckOutItemWithKeyAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWCompleteNWTaskAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWConvertDocumentAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.SPCopyItemAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.SPCopyItemWithKeyAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWCopyToFolderAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWCopyToSharepointSiteAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWCopyToSharepointSite2Adapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWCreateADSecurityGroupAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWCreateADAccountAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWCreateItemWithContentTypesAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWExchangeCreateAppointmentAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWCreateAudienceAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWCreateCRMEntityRecordAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWCreateItemWithContentTypesAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWCreateSiteSpecificItemAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWCreateListAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWCreateList2Adapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWCreateWebAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWCreateWeb2Adapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWCreateSiteCollectionAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWExchangeCreateTaskAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.SPDeclareRecordAdaptor");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWDecommissionUserAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWDeleteSiteCollectionAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWDeleteADSecurityGroupAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.SPDeleteItemAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWDeleteAudienceAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.SPDeleteDraftsAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.SPDeleteItemWithKeyAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWDeleteMultipleItemAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.SPDeletePreviousVersionsAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWDeleteWebAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWDeleteWeb2Adapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWDeleteCRMEntitiesAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.SPUndoCheckOutItemWithKeyAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWEnableLCSOnADAccountAdapter");
            //BatchedActions.Add("Nintex.Workflow.Activities.Adapters.NWWriteToHistoryListAdapter"); not really needed
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWSetModerationStatusAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.SPSetContentApprovalStatusForDocumentSetAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.SPSetCustomWorkflowStatusAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.SPUndeclareRecordAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWUpdateADAccountAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.SPUpdateItemAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.SPUpdateItemAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWUpdateCRMRecordAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWUpdateDocumentAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.SPUpdateItemWithKeyAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWUpdateMultipleItemAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWUpdateUserProfileAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWUpdateXmlAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.SPWaitForAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.SPWaitForWithKeyAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.NWSetItemPermissions");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.SPSetFieldAdapter");
            _batchedActions.Add("Nintex.Workflow.Activities.Adapters.SPSetFieldWithKeyAdapter");
            //BatchedActions.Add("Nintex.Workflow.Activities.Adapters.NWCommitAdapter"); 
            #endregion
        }

        /// <summary>
        /// Check if Activity is considered batched.
        /// </summary>
        /// <param name="activityName">Specify Activity by its full name.</param>
        /// <returns>Boolean</returns>
        public static bool IsBatchedAction(string activityName)
        {
            if (_batchedActions == null) LoadBatchedActionHashSet();
            return _batchedActions.Contains(activityName);
        }
    }
}
