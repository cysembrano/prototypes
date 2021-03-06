﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowFB.Repository.Models
{
    public class FBProject
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public bool PageNumbers { get; set; }
        public Nullable<bool> Boxes { get; set; }
        public Nullable<int> LabelManager { get; set; }
        public Nullable<int> LabelCheckInterval { get; set; }
        public Nullable<int> LabelAlertMin { get; set; }
        public Nullable<bool> FullText { get; set; }
        public Nullable<bool> ShowChangeDate { get; set; }
        public Nullable<int> DividerSecurity { get; set; }
        public Nullable<bool> Imaging { get; set; }
        public Nullable<bool> CAR { get; set; }
        public Nullable<bool> ForceBox { get; set; }
        public Nullable<bool> ImportNewToLabelManager { get; set; }
        public Nullable<int> SecurityField { get; set; }
        public Nullable<bool> MultiKey { get; set; }
        public Nullable<bool> TaskManager { get; set; }
        public string LabelManagerFolder { get; set; }
        public Nullable<bool> MultiLevel { get; set; }
        public Nullable<int> PageSize { get; set; }
        public Nullable<int> NumRevisions { get; set; }
        public Nullable<int> Revisions { get; set; }
        public Nullable<int> NewDocRoute { get; set; }
        public Nullable<int> AllowFileCreateOnBatch { get; set; }
        public string FileRoomEmails { get; set; }
        public Nullable<int> Locking { get; set; }
        public Nullable<int> KeepBox { get; set; }
        public Nullable<int> NewDocRouteAction { get; set; }
        public Nullable<int> IndexDividers { get; set; }
        public Nullable<int> IndexSeparators { get; set; }
        public string ScanEmails { get; set; }
        public Nullable<int> Reminders { get; set; }
        public Nullable<int> FieldSecurity { get; set; }
        public Nullable<bool> FileTracking { get; set; }
        public Nullable<bool> ArchiveEmail { get; set; }
        public Nullable<bool> NoPaper { get; set; }
        public Nullable<int> ServerID { get; set; }
        public Nullable<int> ReportView { get; set; }
        public Nullable<int> LockSep { get; set; }
        public Nullable<int> LockDiv { get; set; }
        public string SepLabel { get; set; }
        public string DivLabel { get; set; }
        public Nullable<int> SeparatorSecurity { get; set; }
        public Nullable<int> SepSortDescending { get; set; }
        public Nullable<int> DivSortDescending { get; set; }
        public Nullable<int> QueueSelect { get; set; }
        public Nullable<int> SaveStyle { get; set; }
        public Nullable<int> Hidden { get; set; }
        public int AllowUnsign { get; set; }
        public Nullable<int> RemoteID { get; set; }
        public int InteractiveRevisions { get; set; }
        public int RenditionPerformed { get; set; }
        public int RenditionAction { get; set; }
        public int RenditionMaximumDimension { get; set; }
        public int ServerOCRType { get; set; }
        public string ServerOCRSkipExtensions { get; set; }
        public Nullable<bool> FBDrive { get; set; }
        public bool DocuSignEnabled { get; set; }
        public int AllowManualDeclaration { get; set; }
        public Nullable<bool> NativePDF { get; set; }
        public int SearchPortalSecurityMode { get; set; }
        public string ProjectType { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
        public bool SearchPortal { get; set; }
        public bool IncludeLineItemSearch { get; set; }
    }
}
