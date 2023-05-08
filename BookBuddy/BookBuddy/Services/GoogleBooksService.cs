using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BookBuddy.Services
{
    public class GoogleBooksService
    {
        private readonly HttpClient _httpClient;

        public GoogleBooksService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<BookSearchResult> SearchBooksByTitleAsync(string title)
        {
            var encodedTitle = Uri.EscapeDataString(title);
            var response = await _httpClient.GetAsync($"https://www.googleapis.com/books/v1/volumes?q=intitle:{encodedTitle}");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<BookSearchResult>(json);
            }
            else
            {
                throw new HttpRequestException($"Failed to retrieve books for title '{title}' with status code {response.StatusCode}");
            }
        }
    }

    public class BookSearchResult
    {
        public int TotalItems { get; set; }
        public List<Book> Items { get; set; }
    }

    public class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public List<string> Authors { get; set; }
        public string Description { get; set; }
        public string ImageLink { get; set; }
        public string PreviewLink { get; set; }
    }
}
