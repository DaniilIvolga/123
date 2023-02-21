string GetHtml(string url, string path)
{
  string html = String.Empty;
  if (!File.Exists(path))
  {
    html = new HttpClient().GetStringAsync(url).Result;
    File.WriteAllText(path, html);
  }
  else
  {
    html = File.ReadAllText(path);
  }
  return html;
}
