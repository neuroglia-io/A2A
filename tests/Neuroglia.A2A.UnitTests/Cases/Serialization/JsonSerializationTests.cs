﻿using System.Text.Json;

namespace Neuroglia.A2A.UnitTests.Cases.Serialization;

public class JsonSerializationTests
{

    [Fact]
    public void Serialize_And_Deserialize_Artifact_Should_Work()
    {
        //arrange
        var toSerialize = new Artifact()
        {
            Name = "fake-name",
            Description = "fake-description",
            Append = true,
            LastChunk = false,
            Index = 69,
            Parts = PartFactory.CreateCollection()
        };

        //act
        var json = JsonSerializer.Serialize(toSerialize);
        var deserialized = JsonSerializer.Deserialize<Artifact>(json);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

    [Fact]
    public void Serialize_And_Deserialize_AuthenticationInfo_Should_Work()
    {
        //arrange
        var toSerialize = AuthenticationInfoFactory.Create();

        //act
        var json = JsonSerializer.Serialize(toSerialize);
        var deserialized = JsonSerializer.Deserialize<AuthenticationInfo>(json);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

    [Fact]
    public void Serialize_And_Deserialize_DataPart_Should_Work()
    {
        //arrange
        var toSerialize = PartFactory.CreateDataPart();

        //act
        var json = JsonSerializer.Serialize(toSerialize);
        var deserialized = JsonSerializer.Deserialize<DataPart>(json);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Type.Should().Be(toSerialize.Type);
        deserialized.Data.First().ToString().Should().Be(toSerialize.Data.First().ToString());
    }

    [Fact]
    public void Serialize_And_Deserialize_File_Should_Work()
    {
        //arrange
        var toSerialize = FileFactory.Create();

        //act
        var json = JsonSerializer.Serialize(toSerialize);
        var deserialized = JsonSerializer.Deserialize<Models.File>(json);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

    [Fact]
    public void Serialize_And_Deserialize_FilePart_Should_Work()
    {
        //arrange
        var toSerialize = PartFactory.CreateFilePart();

        //act
        var json = JsonSerializer.Serialize(toSerialize);
        var deserialized = JsonSerializer.Deserialize<FilePart>(json);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

    [Fact]
    public void Serialize_And_Deserialize_Message_Should_Work()
    {
        //arrange
        var toSerialize = MessageFactory.Create();

        //act
        var json = JsonSerializer.Serialize(toSerialize);
        var deserialized = JsonSerializer.Deserialize<Message>(json);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

    [Fact]
    public void Serialize_And_Deserialize_PushNotificationConfiguration_Should_Work()
    {
        //arrange
        var toSerialize = PushNotificationConfigurationFactory.Create();

        //act
        var json = JsonSerializer.Serialize(toSerialize);
        var deserialized = JsonSerializer.Deserialize<PushNotificationConfiguration>(json);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

    [Fact]
    public void Serialize_And_Deserialize_RpcError_Should_Work()
    {
        //arrange
        var toSerialize = new RpcError()
        {
            Code = 69,
            Message = "fake error message",
            Data = JsonSerializer.SerializeToElement(new { fakeData = "fake-data-value" })};

        //act
        var json = JsonSerializer.Serialize(toSerialize);
        var deserialized = JsonSerializer.Deserialize<RpcError>(json);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Code.Should().Be(toSerialize.Code);
        deserialized.Message.Should().Be(toSerialize.Message);
        deserialized.Data?.ToString().Should().Be(toSerialize.Data?.ToString());
    }

    [Fact]
    public void Serialize_And_Deserialize_Task_Should_Work()
    {
        //arrange
        var toSerialize = Services.TaskFactory.Create();

        //act
        var json = JsonSerializer.Serialize(toSerialize);
        var deserialized = JsonSerializer.Deserialize<Models.Task>(json);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

    [Fact]
    public void Serialize_And_Deserialize_TaskPushNotificationConfiguration_Should_Work()
    {
        //arrange
        var toSerialize = new TaskPushNotificationConfiguration()
        {
            Id = Guid.NewGuid().ToString("N"),
            PushNotificationConfig = PushNotificationConfigurationFactory.Create()
        };

        //act
        var json = JsonSerializer.Serialize(toSerialize);
        var deserialized = JsonSerializer.Deserialize<TaskPushNotificationConfiguration>(json);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

    [Fact]
    public void Serialize_And_Deserialize_TaskStatus_Should_Work()
    {
        //arrange
        var toSerialize = TaskStatusFactory.Create();

        //act
        var json = JsonSerializer.Serialize(toSerialize);
        var deserialized = JsonSerializer.Deserialize<Models.TaskStatus>(json);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

    [Fact]
    public void Serialize_And_Deserialize_TextPart_Should_Work()
    {
        //arrange
        var toSerialize = PartFactory.CreateTextPart();

        //act
        var json = JsonSerializer.Serialize(toSerialize);
        var deserialized = JsonSerializer.Deserialize<TextPart>(json);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

    [Fact]
    public void Serialize_And_Deserialize_SendTaskRequest_Should_Work()
    {
        //arrange
        var toSerialize = new SendTaskRequest()
        {
            JsonRpc = JsonRpcVersion.V2,
            Id = Guid.NewGuid().ToString("N"),
            Parameters = new()
            {
                Id = Guid.NewGuid().ToString("N"),
                SessionId = Guid.NewGuid().ToString("N"),
                HistoryLength = 69,
                Message = MessageFactory.Create(),
                PushNotification = PushNotificationConfigurationFactory.Create()
            }
        };

        //act
        var json = JsonSerializer.Serialize(toSerialize);
        var deserialized = JsonSerializer.Deserialize<SendTaskRequest>(json);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

    [Fact]
    public void Serialize_And_Deserialize_SendTaskResponse_Should_Work()
    {
        //arrange
        var toSerialize = new SendTaskResponse()
        {
            JsonRpc = JsonRpcVersion.V2,
            Id = Guid.NewGuid().ToString("N"),
            Result = Services.TaskFactory.Create()
        };

        //act
        var json = JsonSerializer.Serialize(toSerialize);
        var deserialized = JsonSerializer.Deserialize<SendTaskResponse>(json);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

}
