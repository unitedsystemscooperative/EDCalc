using System;
using System.Net.Http;
using System.Text.Json;

using EDCalculations.EDSM.Models;

using Xunit;

namespace EDCalculations.EDSM.Test.QueriesTest;

public class GetBodiesInSystemAsync
{
    [Fact]
    public async void ShouldCallUsingSystemProvided()
    {
        var expected = new SystemBodies() { name = "Arugbal" };
        var json = JsonSerializer.Serialize(expected);

        HttpClient httpClient = MockClient.GenerateMockClientWithData(json);

        var queries = new Queries(httpClient);

        var bodies = await queries.GetBodiesInSystemAsync("Arugbal");

        Assert.Equal(expected.name, bodies.name);
        Assert.Equal(null, bodies.bodies);
        Assert.Equal(0, bodies.id);
    }

    [Fact]
    public async void ShouldThrowHttpRequestException()
    {
        HttpClient httpClient = MockClient.GenerateMockClientWithError();

        var queries = new Queries(httpClient);

        await Assert.ThrowsAsync<HttpRequestException>(async () => await queries.GetBodiesInSystemAsync("Issues Abound"));
    }
}
