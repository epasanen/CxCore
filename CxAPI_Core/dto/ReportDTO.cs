using System;
using System.Collections.Generic;
using System.Text;

namespace CxAPI_Core.dto
{
    class ReportRequest
    {
        public string reportType { get; set; }
        public long scanId { get; set; }
    }

    public partial class ReportReady
    {
        public Link Link { get; set; }
        public string ContentType { get; set; }
        public ReportStatus Status { get; set; }
    }

    public partial class Link
    {
        public string Rel { get; set; }
        public string Uri { get; set; }
    }

    public partial class ReportState
    {
        public ReportLink Link { get; set; }
        public string ContentType { get; set; }
        public ReportStatus Status { get; set; }

    }
    public partial class ReportTrace
    {
        public long projectId { get; set; }
        public long scanId { get; set; }
        public long reportId { get; set; }
        public bool isRead { get; set; }

        public ReportTrace(long pprojectId, long pScanId, long preportId)
        {
            projectId = pprojectId;
            scanId = pScanId;
            reportId = preportId;
            isRead = false;
        }
    }
    public partial class ReportLink
    {
        public string Rel { get; set; }
        public string Uri { get; set; }
    }
    public partial class ReportStatus
    {
        public long Id { get; set; }
        public string Value { get; set; }
    }

    public partial class ReportResult
    {
        public long ReportId { get; set; }
        public Links Links { get; set; }
    }

    public partial class Links
    {
        public Report Report { get; set; }
        public Report Status { get; set; }
    }

    public partial class Report
    {
        public string Rel { get; set; }
        public string Uri { get; set; }
    }
    public partial class ReportResultNew
    {
        public long projectId { get; set; }
        public long scanId { get; set; }
        public int state { get; set; }
        public string status { get; set; }
        public string Severity { get; set; }
        public string Group { get; set; }
        public string Query { get; set; }
    }
    public partial class ReportOutput
    {
        public string ProjectName { get; set; }
        public int StartHigh { get; set; }
        public int StartMedium { get; set; }
        public int StartLow { get; set; }
        public int LastHigh { get; set; }
        public int LastMedium { get; set; }
        public int LastLow { get; set; }
        public int NewHigh { get; set; }
        public int NewMedium { get; set; }
        public int NewLow { get; set; }
        public int DiffHigh { get; set; }
        public int DiffMedium { get; set; }
        public int DiffLow { get; set; }
        public int NotExploitable { get; set; }
        public int Confirmed { get; set; }
        public int ToVerify { get; set; }
        public DateTimeOffset firstScan { get; set; }
        public DateTimeOffset lastScan { get; set; }
        public int ScanCount { get; set; }

    }
    public partial class ReportStaging
    {
        public long ProjectId { get; set; }
        public long ScanId { get; set; }
        public string ProjectName { get; set; }
        public DateTimeOffset dateTime { get; set; }
        public int High { get; set; }
        public int Medium { get; set; }
        public int Low { get; set; }
        public int ScanCount { get; set; }
    }

}