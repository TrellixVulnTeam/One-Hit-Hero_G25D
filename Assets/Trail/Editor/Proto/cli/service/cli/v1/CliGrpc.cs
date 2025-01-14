#if CSHARP_7_3_OR_NEWER
// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: trail/cli/service/cli/v1/cli.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Trail.Cli.Service.Cli.V1 {
  public static partial class CLIService
  {
    static readonly string __ServiceName = "trail.cli.service.cli.v1.CLIService";

    static readonly grpc::Marshaller<global::Trail.Cli.Service.Cli.V1.GetLoginStatusReq> __Marshaller_trail_cli_service_cli_v1_GetLoginStatusReq = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Trail.Cli.Service.Cli.V1.GetLoginStatusReq.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Trail.Cli.Service.Cli.V1.GetLoginStatusRes> __Marshaller_trail_cli_service_cli_v1_GetLoginStatusRes = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Trail.Cli.Service.Cli.V1.GetLoginStatusRes.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Trail.Cli.Service.Cli.V1.LogInReq> __Marshaller_trail_cli_service_cli_v1_LogInReq = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Trail.Cli.Service.Cli.V1.LogInReq.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Trail.Cli.Service.Cli.V1.LogInRes> __Marshaller_trail_cli_service_cli_v1_LogInRes = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Trail.Cli.Service.Cli.V1.LogInRes.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Trail.Cli.Service.Cli.V1.LogOutReq> __Marshaller_trail_cli_service_cli_v1_LogOutReq = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Trail.Cli.Service.Cli.V1.LogOutReq.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Trail.Cli.Service.Cli.V1.LogOutRes> __Marshaller_trail_cli_service_cli_v1_LogOutRes = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Trail.Cli.Service.Cli.V1.LogOutRes.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Trail.Cli.Service.Cli.V1.ListGamesReq> __Marshaller_trail_cli_service_cli_v1_ListGamesReq = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Trail.Cli.Service.Cli.V1.ListGamesReq.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Trail.Cli.Service.Cli.V1.ListGamesRes> __Marshaller_trail_cli_service_cli_v1_ListGamesRes = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Trail.Cli.Service.Cli.V1.ListGamesRes.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Trail.Cli.Service.Cli.V1.InitializeGameReq> __Marshaller_trail_cli_service_cli_v1_InitializeGameReq = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Trail.Cli.Service.Cli.V1.InitializeGameReq.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Trail.Cli.Service.Cli.V1.InitializeGameRes> __Marshaller_trail_cli_service_cli_v1_InitializeGameRes = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Trail.Cli.Service.Cli.V1.InitializeGameRes.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Trail.Cli.Service.Cli.V1.UploadBuildReq> __Marshaller_trail_cli_service_cli_v1_UploadBuildReq = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Trail.Cli.Service.Cli.V1.UploadBuildReq.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Trail.Cli.Service.Cli.V1.UploadBuildRes> __Marshaller_trail_cli_service_cli_v1_UploadBuildRes = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Trail.Cli.Service.Cli.V1.UploadBuildRes.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Trail.Cli.Service.Cli.V1.RunDevServerReq> __Marshaller_trail_cli_service_cli_v1_RunDevServerReq = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Trail.Cli.Service.Cli.V1.RunDevServerReq.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Trail.Cli.Service.Cli.V1.RunDevServerRes> __Marshaller_trail_cli_service_cli_v1_RunDevServerRes = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Trail.Cli.Service.Cli.V1.RunDevServerRes.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Trail.Cli.Service.Cli.V1.RunBuildReq> __Marshaller_trail_cli_service_cli_v1_RunBuildReq = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Trail.Cli.Service.Cli.V1.RunBuildReq.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Trail.Cli.Service.Cli.V1.RunBuildRes> __Marshaller_trail_cli_service_cli_v1_RunBuildRes = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Trail.Cli.Service.Cli.V1.RunBuildRes.Parser.ParseFrom);

    static readonly grpc::Method<global::Trail.Cli.Service.Cli.V1.GetLoginStatusReq, global::Trail.Cli.Service.Cli.V1.GetLoginStatusRes> __Method_GetLoginStatus = new grpc::Method<global::Trail.Cli.Service.Cli.V1.GetLoginStatusReq, global::Trail.Cli.Service.Cli.V1.GetLoginStatusRes>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetLoginStatus",
        __Marshaller_trail_cli_service_cli_v1_GetLoginStatusReq,
        __Marshaller_trail_cli_service_cli_v1_GetLoginStatusRes);

    static readonly grpc::Method<global::Trail.Cli.Service.Cli.V1.LogInReq, global::Trail.Cli.Service.Cli.V1.LogInRes> __Method_LogIn = new grpc::Method<global::Trail.Cli.Service.Cli.V1.LogInReq, global::Trail.Cli.Service.Cli.V1.LogInRes>(
        grpc::MethodType.Unary,
        __ServiceName,
        "LogIn",
        __Marshaller_trail_cli_service_cli_v1_LogInReq,
        __Marshaller_trail_cli_service_cli_v1_LogInRes);

    static readonly grpc::Method<global::Trail.Cli.Service.Cli.V1.LogOutReq, global::Trail.Cli.Service.Cli.V1.LogOutRes> __Method_LogOut = new grpc::Method<global::Trail.Cli.Service.Cli.V1.LogOutReq, global::Trail.Cli.Service.Cli.V1.LogOutRes>(
        grpc::MethodType.Unary,
        __ServiceName,
        "LogOut",
        __Marshaller_trail_cli_service_cli_v1_LogOutReq,
        __Marshaller_trail_cli_service_cli_v1_LogOutRes);

    static readonly grpc::Method<global::Trail.Cli.Service.Cli.V1.ListGamesReq, global::Trail.Cli.Service.Cli.V1.ListGamesRes> __Method_ListGames = new grpc::Method<global::Trail.Cli.Service.Cli.V1.ListGamesReq, global::Trail.Cli.Service.Cli.V1.ListGamesRes>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListGames",
        __Marshaller_trail_cli_service_cli_v1_ListGamesReq,
        __Marshaller_trail_cli_service_cli_v1_ListGamesRes);

    static readonly grpc::Method<global::Trail.Cli.Service.Cli.V1.InitializeGameReq, global::Trail.Cli.Service.Cli.V1.InitializeGameRes> __Method_InitializeGame = new grpc::Method<global::Trail.Cli.Service.Cli.V1.InitializeGameReq, global::Trail.Cli.Service.Cli.V1.InitializeGameRes>(
        grpc::MethodType.Unary,
        __ServiceName,
        "InitializeGame",
        __Marshaller_trail_cli_service_cli_v1_InitializeGameReq,
        __Marshaller_trail_cli_service_cli_v1_InitializeGameRes);

    static readonly grpc::Method<global::Trail.Cli.Service.Cli.V1.UploadBuildReq, global::Trail.Cli.Service.Cli.V1.UploadBuildRes> __Method_UploadBuild = new grpc::Method<global::Trail.Cli.Service.Cli.V1.UploadBuildReq, global::Trail.Cli.Service.Cli.V1.UploadBuildRes>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "UploadBuild",
        __Marshaller_trail_cli_service_cli_v1_UploadBuildReq,
        __Marshaller_trail_cli_service_cli_v1_UploadBuildRes);

    static readonly grpc::Method<global::Trail.Cli.Service.Cli.V1.RunDevServerReq, global::Trail.Cli.Service.Cli.V1.RunDevServerRes> __Method_RunDevServer = new grpc::Method<global::Trail.Cli.Service.Cli.V1.RunDevServerReq, global::Trail.Cli.Service.Cli.V1.RunDevServerRes>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "RunDevServer",
        __Marshaller_trail_cli_service_cli_v1_RunDevServerReq,
        __Marshaller_trail_cli_service_cli_v1_RunDevServerRes);

    static readonly grpc::Method<global::Trail.Cli.Service.Cli.V1.RunBuildReq, global::Trail.Cli.Service.Cli.V1.RunBuildRes> __Method_RunBuild = new grpc::Method<global::Trail.Cli.Service.Cli.V1.RunBuildReq, global::Trail.Cli.Service.Cli.V1.RunBuildRes>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "RunBuild",
        __Marshaller_trail_cli_service_cli_v1_RunBuildReq,
        __Marshaller_trail_cli_service_cli_v1_RunBuildRes);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Trail.Cli.Service.Cli.V1.CliReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CLIService</summary>
    [grpc::BindServiceMethod(typeof(CLIService), "BindService")]
    public abstract partial class CLIServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Trail.Cli.Service.Cli.V1.GetLoginStatusRes> GetLoginStatus(global::Trail.Cli.Service.Cli.V1.GetLoginStatusReq request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Trail.Cli.Service.Cli.V1.LogInRes> LogIn(global::Trail.Cli.Service.Cli.V1.LogInReq request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Trail.Cli.Service.Cli.V1.LogOutRes> LogOut(global::Trail.Cli.Service.Cli.V1.LogOutReq request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Trail.Cli.Service.Cli.V1.ListGamesRes> ListGames(global::Trail.Cli.Service.Cli.V1.ListGamesReq request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Trail.Cli.Service.Cli.V1.InitializeGameRes> InitializeGame(global::Trail.Cli.Service.Cli.V1.InitializeGameReq request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task UploadBuild(global::Trail.Cli.Service.Cli.V1.UploadBuildReq request, grpc::IServerStreamWriter<global::Trail.Cli.Service.Cli.V1.UploadBuildRes> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task RunDevServer(grpc::IAsyncStreamReader<global::Trail.Cli.Service.Cli.V1.RunDevServerReq> requestStream, grpc::IServerStreamWriter<global::Trail.Cli.Service.Cli.V1.RunDevServerRes> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task RunBuild(grpc::IAsyncStreamReader<global::Trail.Cli.Service.Cli.V1.RunBuildReq> requestStream, grpc::IServerStreamWriter<global::Trail.Cli.Service.Cli.V1.RunBuildRes> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CLIService</summary>
    public partial class CLIServiceClient : grpc::ClientBase<CLIServiceClient>
    {
      /// <summary>Creates a new client for CLIService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CLIServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CLIService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CLIServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CLIServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CLIServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Trail.Cli.Service.Cli.V1.GetLoginStatusRes GetLoginStatus(global::Trail.Cli.Service.Cli.V1.GetLoginStatusReq request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetLoginStatus(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Trail.Cli.Service.Cli.V1.GetLoginStatusRes GetLoginStatus(global::Trail.Cli.Service.Cli.V1.GetLoginStatusReq request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetLoginStatus, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Trail.Cli.Service.Cli.V1.GetLoginStatusRes> GetLoginStatusAsync(global::Trail.Cli.Service.Cli.V1.GetLoginStatusReq request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetLoginStatusAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Trail.Cli.Service.Cli.V1.GetLoginStatusRes> GetLoginStatusAsync(global::Trail.Cli.Service.Cli.V1.GetLoginStatusReq request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetLoginStatus, null, options, request);
      }
      public virtual global::Trail.Cli.Service.Cli.V1.LogInRes LogIn(global::Trail.Cli.Service.Cli.V1.LogInReq request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LogIn(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Trail.Cli.Service.Cli.V1.LogInRes LogIn(global::Trail.Cli.Service.Cli.V1.LogInReq request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_LogIn, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Trail.Cli.Service.Cli.V1.LogInRes> LogInAsync(global::Trail.Cli.Service.Cli.V1.LogInReq request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LogInAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Trail.Cli.Service.Cli.V1.LogInRes> LogInAsync(global::Trail.Cli.Service.Cli.V1.LogInReq request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_LogIn, null, options, request);
      }
      public virtual global::Trail.Cli.Service.Cli.V1.LogOutRes LogOut(global::Trail.Cli.Service.Cli.V1.LogOutReq request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LogOut(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Trail.Cli.Service.Cli.V1.LogOutRes LogOut(global::Trail.Cli.Service.Cli.V1.LogOutReq request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_LogOut, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Trail.Cli.Service.Cli.V1.LogOutRes> LogOutAsync(global::Trail.Cli.Service.Cli.V1.LogOutReq request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LogOutAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Trail.Cli.Service.Cli.V1.LogOutRes> LogOutAsync(global::Trail.Cli.Service.Cli.V1.LogOutReq request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_LogOut, null, options, request);
      }
      public virtual global::Trail.Cli.Service.Cli.V1.ListGamesRes ListGames(global::Trail.Cli.Service.Cli.V1.ListGamesReq request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListGames(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Trail.Cli.Service.Cli.V1.ListGamesRes ListGames(global::Trail.Cli.Service.Cli.V1.ListGamesReq request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListGames, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Trail.Cli.Service.Cli.V1.ListGamesRes> ListGamesAsync(global::Trail.Cli.Service.Cli.V1.ListGamesReq request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListGamesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Trail.Cli.Service.Cli.V1.ListGamesRes> ListGamesAsync(global::Trail.Cli.Service.Cli.V1.ListGamesReq request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListGames, null, options, request);
      }
      public virtual global::Trail.Cli.Service.Cli.V1.InitializeGameRes InitializeGame(global::Trail.Cli.Service.Cli.V1.InitializeGameReq request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return InitializeGame(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Trail.Cli.Service.Cli.V1.InitializeGameRes InitializeGame(global::Trail.Cli.Service.Cli.V1.InitializeGameReq request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_InitializeGame, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Trail.Cli.Service.Cli.V1.InitializeGameRes> InitializeGameAsync(global::Trail.Cli.Service.Cli.V1.InitializeGameReq request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return InitializeGameAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Trail.Cli.Service.Cli.V1.InitializeGameRes> InitializeGameAsync(global::Trail.Cli.Service.Cli.V1.InitializeGameReq request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_InitializeGame, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::Trail.Cli.Service.Cli.V1.UploadBuildRes> UploadBuild(global::Trail.Cli.Service.Cli.V1.UploadBuildReq request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UploadBuild(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::Trail.Cli.Service.Cli.V1.UploadBuildRes> UploadBuild(global::Trail.Cli.Service.Cli.V1.UploadBuildReq request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_UploadBuild, null, options, request);
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Trail.Cli.Service.Cli.V1.RunDevServerReq, global::Trail.Cli.Service.Cli.V1.RunDevServerRes> RunDevServer(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RunDevServer(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Trail.Cli.Service.Cli.V1.RunDevServerReq, global::Trail.Cli.Service.Cli.V1.RunDevServerRes> RunDevServer(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_RunDevServer, null, options);
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Trail.Cli.Service.Cli.V1.RunBuildReq, global::Trail.Cli.Service.Cli.V1.RunBuildRes> RunBuild(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RunBuild(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Trail.Cli.Service.Cli.V1.RunBuildReq, global::Trail.Cli.Service.Cli.V1.RunBuildRes> RunBuild(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_RunBuild, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CLIServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CLIServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CLIServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetLoginStatus, serviceImpl.GetLoginStatus)
          .AddMethod(__Method_LogIn, serviceImpl.LogIn)
          .AddMethod(__Method_LogOut, serviceImpl.LogOut)
          .AddMethod(__Method_ListGames, serviceImpl.ListGames)
          .AddMethod(__Method_InitializeGame, serviceImpl.InitializeGame)
          .AddMethod(__Method_UploadBuild, serviceImpl.UploadBuild)
          .AddMethod(__Method_RunDevServer, serviceImpl.RunDevServer)
          .AddMethod(__Method_RunBuild, serviceImpl.RunBuild).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CLIServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetLoginStatus, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Trail.Cli.Service.Cli.V1.GetLoginStatusReq, global::Trail.Cli.Service.Cli.V1.GetLoginStatusRes>(serviceImpl.GetLoginStatus));
      serviceBinder.AddMethod(__Method_LogIn, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Trail.Cli.Service.Cli.V1.LogInReq, global::Trail.Cli.Service.Cli.V1.LogInRes>(serviceImpl.LogIn));
      serviceBinder.AddMethod(__Method_LogOut, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Trail.Cli.Service.Cli.V1.LogOutReq, global::Trail.Cli.Service.Cli.V1.LogOutRes>(serviceImpl.LogOut));
      serviceBinder.AddMethod(__Method_ListGames, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Trail.Cli.Service.Cli.V1.ListGamesReq, global::Trail.Cli.Service.Cli.V1.ListGamesRes>(serviceImpl.ListGames));
      serviceBinder.AddMethod(__Method_InitializeGame, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Trail.Cli.Service.Cli.V1.InitializeGameReq, global::Trail.Cli.Service.Cli.V1.InitializeGameRes>(serviceImpl.InitializeGame));
      serviceBinder.AddMethod(__Method_UploadBuild, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Trail.Cli.Service.Cli.V1.UploadBuildReq, global::Trail.Cli.Service.Cli.V1.UploadBuildRes>(serviceImpl.UploadBuild));
      serviceBinder.AddMethod(__Method_RunDevServer, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Trail.Cli.Service.Cli.V1.RunDevServerReq, global::Trail.Cli.Service.Cli.V1.RunDevServerRes>(serviceImpl.RunDevServer));
      serviceBinder.AddMethod(__Method_RunBuild, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Trail.Cli.Service.Cli.V1.RunBuildReq, global::Trail.Cli.Service.Cli.V1.RunBuildRes>(serviceImpl.RunBuild));
    }

  }
}
#endregion

#endif
