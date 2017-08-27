# DragCoordinatesUITestRepro
Reproduction of a regression in Xamarin.UITest v2.0.10

## Error
The following error appers when performing `DragCoordinates` on iOS:

>System.Exception : Error while performing DragCoordinates(187.5, 84, 187.5, 647, null)
  ----> System.AggregateException : One or more errors occurred.
  ----> Microsoft.CSharp.RuntimeBinder.RuntimeBinderException : Cannot implicitly convert type 'void' to 'object'
  
Note: `DragCoordinates` works fine on Android.

## Reproduction Steps
1. Download and open DragCoordinatesUITestRepro.sln
2. Build/Compile `DragCoordinatesUITestRepro.iOS`
3. Build/Compile `DragCoordinatesUITestRepro.UITests`
4. Run the `PullToRefresh_DragDropCoordinates` UITest on `DragCoordinatesUITestRepro.iOS` running iOS 10.3
5. The tests fails `System.Exception : Error while performing DragCoordinates`

## Work Around
1. Install Xamarin.UITest v2.0.9
2. Run the `PullToRefresh_DragDropCoordinates` UITest on `DragCoordinatesUITestRepro.iOS` running iOS 10.3

## Environment

=== Visual Studio Enterprise 2017 for Mac ===

Version 7.1 (build 1297)
Installation UUID: 6e5142b4-e8be-4d1c-b75e-4744b0d8c3de

Runtime:

- Mono 5.2.0.215 (d15-3/da80840) (64-bit)
- GTK+ 2.24.23 (Raleigh theme)
- Package version: 502000215

=== NuGet ===

Version: 4.3.0.2418

=== .NET Core ===

Runtime: /usr/local/share/dotnet/dotnet
Runtime Versions:
	1.1.1
	1.0.4
SDK: /usr/local/share/dotnet/sdk/1.0.1/Sdks
SDK Version: 1.0.1
MSBuild SDKs: /Library/Frameworks/Mono.framework/Versions/5.2.0/lib/mono/msbuild/15.0/bin/Sdks

=== Xamarin.Profiler ===

Version: 1.5.5
Location: /Applications/Xamarin Profiler.app/Contents/MacOS/Xamarin Profiler

=== Apple Developer Tools ===

Xcode 8.3.3 (12175.1)
Build 8E3004b

=== Xamarin.iOS ===

Version: 10.12.0.20 (Visual Studio Enterprise)
Hash: 80b8487d
Branch: d15-3
Build date: 2017-08-18 16:07:26-0400

=== Xamarin.Android ===

Version: 7.4.0.21 (Visual Studio Enterprise)
Android SDK: /Users/brandonm/Library/Developer/Xamarin/android-sdk-macosx
	Supported Android versions:
		4.1 (API level 16)
		6.0 (API level 23)
		7.0 (API level 24)
		7.1 (API level 25)

SDK Tools Version: 26.0.2
SDK Platform Tools Version: 26.0.0
SDK Build Tools Version: 26.0.1

Java SDK: /usr
java version "1.8.0_121"
Java(TM) SE Runtime Environment (build 1.8.0_121-b13)
Java HotSpot(TM) 64-Bit Server VM (build 25.121-b13, mixed mode)

Android Designer EPL code available here:
https://github.com/xamarin/AndroidDesigner.EPL

=== Xamarin Inspector ===

Version: 1.2.2
Hash: b71b035
Branch: d15-1
Build date: Fri, 21 Apr 2017 17:57:12 GMT

=== Xamarin.Mac ===

Version: 3.6.0.19 (Visual Studio Enterprise)

=== Build Information ===

Release ID: 701001297
Git revision: 9c5299666538b2f8baf501418a5c064d784d64da
Build date: 2017-08-07 11:29:35-04
Xamarin addins: 3bb0c32a14f1b7e368bf5ac53a84c3581c019391
Build lane: monodevelop-lion-d15-3

=== Operating System ===

Mac OS X 10.12.5
Darwin 16.6.0 Darwin Kernel Version 16.6.0
    Fri Apr 14 16:21:16 PDT 2017
    root:xnu-3789.60.24~6/RELEASE_X86_64 x86_64

=== Enabled user installed addins ===

NuGet Package Management Extensions 0.12.2

