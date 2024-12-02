using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DomainModels.WebEntities
{

    public class JiraIssueResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("self")]
        public string Self { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("statuscategorychangedate")]
        public string StatusCategoryChangeDate { get; set; }

        [JsonPropertyName("issuetype")]
        public IssueType IssueType { get; set; }

        [JsonPropertyName("parent")]
        public Parent Parent { get; set; }

        [JsonPropertyName("timespent")]
        public object TimeSpent { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("expand")]
        public string Expand { get; set; }

        [JsonPropertyName("startAt")]
        public int StartAt { get; set; }

        [JsonPropertyName("maxResults")]
        public int MaxResults { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("issues")]
        public List<Issue> Issues { get; set; }
    }

    public class Issue
    {
        [JsonPropertyName("expand")]
        public string Expand { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("self")]
        public string Self { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("fields")]
        public Fields Fields { get; set; }
    }

    public class Fields
    {
        [JsonPropertyName("statuscategorychangedate")]
        public string StatusCategoryChangeDate { get; set; }

        [JsonPropertyName("issuetype")]
        public IssueType IssueType { get; set; }

        [JsonPropertyName("parent")]
        public Parent Parent { get; set; }

        [JsonPropertyName("timespent")]
        public object TimeSpent { get; set; }

        [JsonPropertyName("customfield_10030")]
        public object CustomField10030 { get; set; }

        [JsonPropertyName("project")]
        public JiraIssueProject Project { get; set; }

        [JsonPropertyName("customfield_10031")]
        public object CustomField10031 { get; set; }

        [JsonPropertyName("fixVersions")]
        public List<object> FixVersions { get; set; }

        [JsonPropertyName("customfield_10033")]
        public object CustomField10033 { get; set; }

        [JsonPropertyName("customfield_10034")]
        public object CustomField10034 { get; set; }

        [JsonPropertyName("aggregatetimespent")]
        public object AggregateTimeSpent { get; set; }

        [JsonPropertyName("resolution")]
        public object Resolution { get; set; }

        [JsonPropertyName("customfield_10035")]
        public object CustomField10035 { get; set; }

        [JsonPropertyName("customfield_10036")]
        public object CustomField10036 { get; set; }

        [JsonPropertyName("customfield_10027")]
        public object CustomField10027 { get; set; }

        [JsonPropertyName("customfield_10028")]
        public object CustomField10028 { get; set; }

        [JsonPropertyName("customfield_10029")]
        public object CustomField10029 { get; set; }

        [JsonPropertyName("resolutiondate")]
        public object ResolutionDate { get; set; }

        [JsonPropertyName("workratio")]
        public int WorkRatio { get; set; }

        [JsonPropertyName("watches")]
        public Watches Watches { get; set; }

        [JsonPropertyName("lastViewed")]
        public object LastViewed { get; set; }

        [JsonPropertyName("created")]
        public string Created { get; set; }

        [JsonPropertyName("customfield_10020")]
        public object CustomField10020 { get; set; }

        [JsonPropertyName("customfield_10021")]
        public object CustomField10021 { get; set; }

        [JsonPropertyName("customfield_10022")]
        public object CustomField10022 { get; set; }

        [JsonPropertyName("priority")]
        public Priority Priority { get; set; }

        [JsonPropertyName("customfield_10023")]
        public object CustomField10023 { get; set; }

        [JsonPropertyName("customfield_10024")]
        public object CustomField10024 { get; set; }

        [JsonPropertyName("customfield_10025")]
        public object CustomField10025 { get; set; }

        [JsonPropertyName("customfield_10026")]
        public object CustomField10026 { get; set; }

        [JsonPropertyName("labels")]
        public List<object> Labels { get; set; }

        [JsonPropertyName("customfield_10016")]
        public object CustomField10016 { get; set; }

        [JsonPropertyName("customfield_10017")]
        public object CustomField10017 { get; set; }

        [JsonPropertyName("customfield_10018")]
        public CustomField10018 CustomField10018 { get; set; }

        [JsonPropertyName("customfield_10019")]
        public string CustomField10019 { get; set; }

        [JsonPropertyName("timeestimate")]
        public object TimeEstimate { get; set; }

        [JsonPropertyName("aggregatetimeoriginalestimate")]
        public object AggregateTimeOriginalEstimate { get; set; }

        [JsonPropertyName("versions")]
        public List<object> Versions { get; set; }

        [JsonPropertyName("issuelinks")]
        public List<object> IssueLinks { get; set; }

        [JsonPropertyName("assignee")]
        public object Assignee { get; set; }

        [JsonPropertyName("updated")]
        public string Updated { get; set; }

        [JsonPropertyName("status")]
        public Status Status { get; set; }

        [JsonPropertyName("components")]
        public List<object> Components { get; set; }

        [JsonPropertyName("timeoriginalestimate")]
        public object TimeOriginalEstimate { get; set; }

        [JsonPropertyName("description")]
        public Description Description { get; set; }

        [JsonPropertyName("customfield_10010")]
        public object CustomField10010 { get; set; }

        [JsonPropertyName("customfield_10014")]
        public string CustomField10014 { get; set; }

        [JsonPropertyName("customfield_10015")]
        public object CustomField10015 { get; set; }

        [JsonPropertyName("customfield_10005")]
        public object CustomField10005 { get; set; }

        [JsonPropertyName("customfield_10006")]
        public object CustomField10006 { get; set; }

        [JsonPropertyName("security")]
        public object Security { get; set; }

        [JsonPropertyName("customfield_10007")]
        public object CustomField10007 { get; set; }

        [JsonPropertyName("customfield_10008")]
        public object CustomField10008 { get; set; }

        [JsonPropertyName("customfield_10009")]
        public object CustomField10009 { get; set; }

        [JsonPropertyName("aggregatetimeestimate")]
        public object AggregateTimeEstimate { get; set; }

        [JsonPropertyName("summary")]
        public string Summary { get; set; }

        [JsonPropertyName("creator")]
        public User Creator { get; set; }

        [JsonPropertyName("subtasks")]
        public List<object> SubTasks { get; set; }

        [JsonPropertyName("reporter")]
        public User Reporter { get; set; }

        [JsonPropertyName("aggregateprogress")]
        public Progress AggregateProgress { get; set; }

        [JsonPropertyName("customfield_10001")]
        public object CustomField10001 { get; set; }

        [JsonPropertyName("customfield_10002")]
        public List<object> CustomField10002 { get; set; }

        [JsonPropertyName("customfield_10003")]
        public object CustomField10003 { get; set; }

        [JsonPropertyName("customfield_10004")]
        public object CustomField10004 { get; set; }

        [JsonPropertyName("environment")]
        public object Environment { get; set; }

        [JsonPropertyName("duedate")]
        public object DueDate { get; set; }

        [JsonPropertyName("progress")]
        public Progress Progress { get; set; }

        [JsonPropertyName("votes")]
        public Votes Votes { get; set; }
    }

    public class IssueType
    {
        [JsonPropertyName("self")]
        public string Self { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("iconUrl")]
        public string IconUrl { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("subtask")]
        public bool SubTask { get; set; }

        [JsonPropertyName("avatarId")]
        public int AvatarId { get; set; }

        [JsonPropertyName("hierarchyLevel")]
        public int HierarchyLevel { get; set; }
    }

    public class Parent
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("self")]
        public string Self { get; set; }

        [JsonPropertyName("fields")]
        public ParentFields Fields { get; set; }
    }

    public class ParentFields
    {
        [JsonPropertyName("summary")]
        public string Summary { get; set; }

        [JsonPropertyName("status")]
        public Status Status { get; set; }

        [JsonPropertyName("priority")]
        public Priority Priority { get; set; }

        [JsonPropertyName("issuetype")]
        public IssueType IssueType { get; set; }
    }

    public class JiraIssueProject
    {
        [JsonPropertyName("self")]
        public string Self { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("projectTypeKey")]
        public string ProjectTypeKey { get; set; }

        [JsonPropertyName("simplified")]
        public bool Simplified { get; set; }

        [JsonPropertyName("avatarUrls")]
        public AvatarUrls AvatarUrls { get; set; }
    }

    public class Watches
    {
        [JsonPropertyName("self")]
        public string Self { get; set; }

        [JsonPropertyName("watchCount")]
        public int WatchCount { get; set; }

        [JsonPropertyName("isWatching")]
        public bool IsWatching { get; set; }
    }

    public class Priority
    {
        [JsonPropertyName("self")]
        public string Self { get; set; }

        [JsonPropertyName("iconUrl")]
        public string IconUrl { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }

    public class CustomField10018
    {
        [JsonPropertyName("hasEpicLinkFieldDependency")]
        public bool HasEpicLinkFieldDependency { get; set; }

        [JsonPropertyName("showField")]
        public bool ShowField { get; set; }

        [JsonPropertyName("nonEditableReason")]
        public NonEditableReason NonEditableReason { get; set; }
    }

    public class NonEditableReason
    {
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }
    }

    public class Status
    {
        [JsonPropertyName("self")]
        public string Self { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("iconUrl")]
        public string IconUrl { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("statusCategory")]
        public StatusCategory StatusCategory { get; set; }
    }

    public class StatusCategory
    {
        [JsonPropertyName("self")]
        public string Self { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("colorName")]
        public string ColorName { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Description
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("version")]
        public int Version { get; set; }

        [JsonPropertyName("content")]
        public List<Content> Content { get; set; }
    }

    public class Content
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("content")]
        public List<TextContent> ContentList { get; set; }
    }

    public class TextContent
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class User
    {
        [JsonPropertyName("self")]
        public string Self { get; set; }

        [JsonPropertyName("accountId")]
        public string AccountId { get; set; }

        [JsonPropertyName("avatarUrls")]
        public AvatarUrls AvatarUrls { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("active")]
        public bool Active { get; set; }

        [JsonPropertyName("timeZone")]
        public string TimeZone { get; set; }

        [JsonPropertyName("accountType")]
        public string AccountType { get; set; }
    }

    public class Progress
    {
        [JsonPropertyName("progress")]
        public int ProgressValue { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }
    }

    public class Votes
    {
        [JsonPropertyName("self")]
        public string Self { get; set; }

        [JsonPropertyName("votes")]
        public int VotesCount { get; set; }

        [JsonPropertyName("hasVoted")]
        public bool HasVoted { get; set; }
    }

}
