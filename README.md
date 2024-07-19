# UnoStackedNugetPackageIssue

Reported as issue #17507
Title:
Unable to include stacked nuget package in another package or App.

Current behaviour
If a nuget package contains another nuget package based on a Uno library, that new package cannot be included in a further App or library.

On adding the dependency the following error is generated.

Restoring packages for D:\Development\GitHub\UnoStackedNugetPackageIssue\Package3\Package3.csproj...
System.IO.DirectoryNotFoundException: Could not find a part of the path 'C:\Users\vsoft\.nuget\packages\vssl.sample.package2\1.0.0\contentFiles\any\net8.0-windows10.0.19041\bin\Debug\net8.0-windows10.0.19041\Vssl.Sample.Package2\obj\Debug\net8.0-android\lp\84\jl\res\drawable-xxhdpi-v4\abc_textfield_search_activated_mtrl_alpha.9.png'.
   at System.IO.__Error.WinIOError(Int32 errorCode, String maybeFullPath)
   at System.IO.FileStream.Init(String path, FileMode mode, FileAccess access, Int32 rights, Boolean useRights, FileShare share, Int32 bufferSize, FileOptions options, SECURITY_ATTRIBUTES secAttrs, String msgPath, Boolean bFromProxy, Boolean useLongPath, Boolean checkHost)
   at System.IO.FileStream..ctor(String path, FileMode mode, FileAccess access, FileShare share, Int32 bufferSize)
   at System.IO.File.Create(String path)
   at NuGet.Packaging.StreamExtensions.Testable.MmapCopy(Stream inputStream, String fileFullPath, Int64 size)
   at NuGet.Packaging.StreamExtensions.Testable.CopyToFile(Stream inputStream, String fileFullPath)
   at NuGet.Packaging.PackageFileExtractor.ExtractPackageFile(String source, String target, Stream stream)
   at NuGet.Packaging.PackageArchiveReader.CopyFiles(String destination, IEnumerable`1 packageFiles, ExtractPackageFileDelegate extractFile, ILogger logger, CancellationToken token)
   at NuGet.Packaging.PackageReaderBase.CopyFilesAsync(String destination, IEnumerable`1 packageFiles, ExtractPackageFileDelegate extractFile, ILogger logger, CancellationToken cancellationToken)
   at NuGet.Packaging.PackageExtractor.<>c__DisplayClass5_0.<<InstallFromSourceAsync>b__0>d.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at NuGet.Common.ConcurrencyUtilities.<ExecuteWithFileLockedAsync>d__5`1.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at NuGet.Common.ConcurrencyUtilities.<ExecuteWithFileLockedAsync>d__5`1.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at NuGet.Packaging.PackageExtractor.<InstallFromSourceAsync>d__5.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at NuGet.Commands.ProjectRestoreCommand.<InstallPackageAsync>d__16.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at NuGet.Commands.ProjectRestoreCommand.<InstallPackagesAsync>d__15.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at NuGet.Commands.ProjectRestoreCommand.<TryRestoreAsync>d__9.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at NuGet.Commands.RestoreCommand.<ExecuteRestoreAsync>d__86.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at NuGet.Commands.RestoreCommand.<ExecuteAsync>d__68.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at NuGet.Commands.RestoreRunner.<ExecuteAsync>d__7.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at NuGet.Commands.RestoreRunner.<CompleteTaskAsync>d__10.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at NuGet.Commands.RestoreRunner.<RunWithoutCommit>d__3.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at NuGet.PackageManagement.DependencyGraphRestoreUtility.<PreviewRestoreProjectsAsync>d__5.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at NuGet.PackageManagement.NuGetPackageManager.<PreviewBuildIntegratedProjectsActionsAsync>d__89.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at NuGet.PackageManagement.NuGetPackageManager.<PreviewProjectsInstallPackageAsync>d__75.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at NuGet.PackageManagement.VisualStudio.NuGetProjectManagerService.<>c__DisplayClass22_0.<<GetInstallActionsAsync>b__0>d.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at NuGet.PackageManagement.VisualStudio.NuGetProjectManagerService.<CatchAndRethrowExceptionAsync>d__33`1.MoveNext()
Time Elapsed: 00:00:10.1788300
========== Finished ==========


Note the following files generated in Package 2
See expanded project.png file in screen shots 

And how these files are included in the package
See nuget contents.png file in screen shots 

Expected behaviour:
Should be able include Uno based nuget packages to any depth.

Workaround:
None found

========================================================================================

Confirm resolved in Uno.Sdk 5.4.0-dev.135