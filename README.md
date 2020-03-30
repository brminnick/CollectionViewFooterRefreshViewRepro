# CollectionViewFooterRefreshViewRepro
 Reproduction sample for `Xamarin.Forms.CollectionView` bug.
 
 When a `Footer` is added to a `CollectionView` inside of a `RefreshView`, the Refresh Indicator is no longer visible
 
 ## Reproduction Steps
 
1. Download / Clone this repo
2. In Visual Studio, open CollectionViewFooterRefreshViewRepro.sln
3. Build / deploy CollectionViewFooterRefreshViewRepro.iOS to an iOS Simulator or Device
4. On the iOS App, select `CollectionView without Footer`
5. On the No Footer page, confirm the Refresh Indicator is visible
6. On the No Footer page, after the list has finished refreshing, pull-to-refresh on the list
7. On the No Footer page, confirm the Refresh Indicator is visible
8. On the No Footer page, click the back button
9. On the iOS App, select `CollectionView with Footer`
10. On the With Footer page, confirm the Refresh Indicator is not visible
11. On the With Footer page, after the list has finished refreshing, pull-to-refresh on the list
12. On the With Footer page, confirm the vertical list alignment has shifted above the navigation bar


![](https://user-images.githubusercontent.com/13558917/77955652-6b061900-7285-11ea-8d0b-c6a8c1657d32.gif)

## Environment

=== Visual Studio Enterprise 2019 for Mac (Preview) ===

Version 8.6 Preview (8.6 build 3437)
Installation UUID: a44d4204-8983-463e-b5df-b42ca6eea6d4
	GTK+ 2.24.23 (Raleigh theme)
	Xamarin.Mac 6.18.0.21 (d16-6 / a87d63c06)

	Package version: 610000095

=== Mono Framework MDK ===

Runtime:
	Mono 6.10.0.95 (2019-12/f2379f2d665) (64-bit)
	Package version: 610000095

=== Roslyn (Language Service) ===

3.6.0-2.20164.4+923b4bdbbd33307456464f4c90222a61af278972

=== NuGet ===

Version: 5.4.0.6315

=== .NET Core SDK ===

SDK: /usr/local/share/dotnet/sdk/3.1.200/Sdks
SDK Versions:
	3.1.200
	3.1.102
	3.0.101
	2.1.803
MSBuild SDKs: /Library/Frameworks/Mono.framework/Versions/6.10.0/lib/mono/msbuild/Current/bin/Sdks

=== .NET Core Runtime ===

Runtime: /usr/local/share/dotnet/dotnet
Runtime Versions:
	5.0.0-preview.1.20120.5
	3.1.2
	3.1.1
	3.1.0
	3.0.1
	2.1.16
	2.1.15
	2.1.14

=== Xamarin.Profiler ===

Version: 1.6.13.11
Location: /Applications/Xamarin Profiler.app/Contents/MacOS/Xamarin Profiler

=== Updater ===

Version: 11

=== Apple Developer Tools ===

Xcode 11.4 (16134)
Build 11E146

=== Xamarin.Mac ===

Xamarin.Mac not installed. Can't find /Library/Frameworks/Xamarin.Mac.framework/Versions/Current/Version.

=== Xamarin.iOS ===

Version: 13.18.0.21 (Visual Studio Enterprise)
Hash: a87d63c06
Branch: d16-6
Build date: 2020-03-02 11:17:05-0500

=== Xamarin Designer ===

Version: 16.6.0.267
Hash: fa27dc7ce
Branch: remotes/origin/d16-6
Build date: 2020-03-19 20:26:14 UTC

=== Xamarin.Android ===

Version: 10.3.0.33 (Visual Studio Enterprise)
Commit: xamarin-android/d16-6/e9fa8c4
Android SDK: /Users/bramin/Library/Developer/Xamarin/android-sdk-macosx
	Supported Android versions:
		7.0 (API level 24)

SDK Tools Version: 26.1.1
SDK Platform Tools Version: 29.0.5
SDK Build Tools Version: 29.0.2

Build Information: 
Mono: d90665a
Java.Interop: xamarin/java.interop/d16-6@2cab35c
ProGuard: xamarin/proguard/master@905836d
SQLite: xamarin/sqlite/3.31.1@49232bc
Xamarin.Android Tools: xamarin/xamarin-android-tools/d16-6@bfb66f3

=== Microsoft Mobile OpenJDK ===

Java SDK: /Users/bramin/Library/Developer/Xamarin/jdk/microsoft_dist_openjdk_1.8.0.25
1.8.0-25
Android Designer EPL code available here:
https://github.com/xamarin/AndroidDesigner.EPL

=== Android SDK Manager ===

Version: 16.6.0.46
Hash: f6bfa7b
Branch: remotes/origin/d16-6
Build date: 2020-03-13 00:13:30 UTC

=== Android Device Manager ===

Version: 16.6.0.75
Hash: 4509c53
Branch: remotes/origin/d16-6
Build date: 2020-03-13 00:13:52 UTC

=== Xamarin Inspector ===

Version: 1.4.3
Hash: db27525
Branch: 1.4-release
Build date: Mon, 09 Jul 2018 21:20:18 GMT
Client compatibility: 1

=== Build Information ===

Release ID: 806003437
Git revision: b6e23a27c18a3e6f8eb620ff1814fb76b3f47921
Build date: 2020-03-20 11:39:40-04
Build branch: release-8.6
Xamarin extensions: b6e23a27c18a3e6f8eb620ff1814fb76b3f47921

=== Operating System ===

Mac OS X 10.15.4
Darwin 19.4.0 Darwin Kernel Version 19.4.0
    Wed Mar  4 22:28:40 PST 2020
    root:xnu-6153.101.6~15/RELEASE_X86_64 x86_64

