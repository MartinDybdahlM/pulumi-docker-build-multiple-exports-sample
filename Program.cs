using Pulumi;
using Pulumi.DockerBuild;
using Pulumi.DockerBuild.Inputs;

return await Deployment.RunAsync(() =>
{
    _ = new Image(
        "sample-image",
        new ImageArgs
        {
            Dockerfile = new DockerfileArgs { Location = "./Dockerfile" },
            Context = new BuildContextArgs { Location = "." },
            Platforms = new[] { Platform.Linux_arm64 },
            Push = false,
            Exec = true,
            Tags = new[] { "sample-image" },
            Exports = new[] { new ExportArgs { Docker = new ExportDockerArgs() }, new ExportArgs { Docker = new ExportDockerArgs() } },
        }
    );
});

