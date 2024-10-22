
using System.Net;
using Moq;
using Moq.Protected;
using Xunit;

namespace InterviewQuestions
{

    public class HttpClientSampleTest
    {
        [Fact]
        public async Task FetchDataAsync_ReturnsContent_WhenSuccessful()
        {
            // Arrange
            var mockHttpClient = new Mock<HttpMessageHandler>();
            mockHttpClient
                .Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    It.IsAny<HttpRequestMessage>(),
                    It.IsAny<CancellationToken>()
                )
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent("{ \"title\": \"Test Title\" }"),
                });

            var httpClient = new HttpClient(mockHttpClient.Object);
            var dataFetcher = new HttpClientSample(httpClient);
            string url = "https://jsonplaceholder.typicode.com/posts/1";

            // Act
            string result = await dataFetcher.FetchDataAsync(url);

            // Assert
            Xunit.Assert.Contains("Test Title", result);
        }

        [Fact]
        public async Task FetchDataAsync_ThrowsException_WhenUnsuccessful()
        {
            // Arrange
            var mockHttpClient = new Mock<HttpMessageHandler>();
            mockHttpClient
                .Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    It.IsAny<HttpRequestMessage>(),
                    It.IsAny<CancellationToken>()
                )
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.NotFound,
                });

            var httpClient = new HttpClient(mockHttpClient.Object);
            var dataFetcher = new HttpClientSample(httpClient);
            string url = "https://jsonplaceholder.typicode.com/posts/1";

            // Act & Assert
            await Xunit.Assert.ThrowsAsync<HttpRequestException>(() => dataFetcher.FetchDataAsync(url));
        }
    }
}
