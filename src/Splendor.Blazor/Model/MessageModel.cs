namespace Splendor.Blazor.Model
{
    public class MessageModel
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public void Set(string content, string title = null)
        {
            Title = title ?? "";
            Content = content;
        }

        public bool IsEmpty() => string.IsNullOrWhiteSpace(Title) && string.IsNullOrWhiteSpace(Content);
    }
}
