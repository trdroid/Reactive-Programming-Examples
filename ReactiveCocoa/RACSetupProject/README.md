### Creating the project

macOS Sierra Version 10.12 (16A323)

Xcode Version 8.0 (8A218a)

The instructions specified at https://github.com/ReactiveCocoa/ReactiveCocoa are

```
ReactiveCocoa supports OS X 10.9+, iOS 8.0+, watchOS 2.0, and tvOS 9.0.

To add RAC to your application:

Add the ReactiveCocoa repository as a submodule of your application’s repository.
Run git submodule update --init --recursive from within the ReactiveCocoa folder.
Drag and drop ReactiveCocoa.xcodeproj, Carthage/Checkouts/ReactiveSwift/ReactiveSwift.xcodeproj, and Carthage/Checkouts/Result/Result.xcodeproj into your application’s Xcode project or workspace.
On the “General” tab of your application target’s settings, add ReactiveCocoa.framework, ReactiveSwift.framework, and Result.framework to the “Embedded Binaries” section.
If your application target does not contain Swift code at all, you should also set the EMBEDDED_CONTENT_CONTAINS_SWIFT build setting to “Yes”.
```

**Adding ReactiveCocoa repository as a submodule**

```sh
droid@Yamz:~/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupProject$ git submodule add -b master https://github.com/ReactiveCocoa/ReactiveCocoa
Cloning into '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupProject/ReactiveCocoa'...
remote: Counting objects: 46513, done.
remote: Compressing objects: 100% (169/169), done.
remote: Total 46513 (delta 99), reused 0 (delta 0), pack-reused 46339
Receiving objects: 100% (46513/46513), 15.62 MiB | 2.85 MiB/s, done.
Resolving deltas: 100% (29625/29625), done.
Checking connectivity... done.
```

**Updating submodules**

```sh
droid@Yamz:~/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupProject$ git submodule update --init --recursive
Submodule 'Carthage/Checkouts/Nimble' (https://github.com/Quick/Nimble.git) registered for path 'ReactiveCocoa/Carthage/Checkouts/Nimble'
Submodule 'Carthage/Checkouts/Quick' (https://github.com/Quick/Quick.git) registered for path 'ReactiveCocoa/Carthage/Checkouts/Quick'
Submodule 'Carthage/Checkouts/ReactiveSwift' (https://github.com/ReactiveCocoa/ReactiveSwift.git) registered for path 'ReactiveCocoa/Carthage/Checkouts/ReactiveSwift'
Submodule 'Carthage/Checkouts/Result' (https://github.com/antitypical/Result.git) registered for path 'ReactiveCocoa/Carthage/Checkouts/Result'
Submodule 'Carthage/Checkouts/xcconfigs' (https://github.com/jspahrsummers/xcconfigs.git) registered for path 'ReactiveCocoa/Carthage/Checkouts/xcconfigs'
Cloning into '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupProject/ReactiveCocoa/Carthage/Checkouts/Nimble'...
remote: Counting objects: 5895, done.
remote: Compressing objects: 100% (2/2), done.
remote: Total 5895 (delta 0), reused 0 (delta 0), pack-reused 5893
Receiving objects: 100% (5895/5895), 1.21 MiB | 1.58 MiB/s, done.
Resolving deltas: 100% (4015/4015), done.
Checking connectivity... done.
Submodule path 'ReactiveCocoa/Carthage/Checkouts/Nimble': checked out '0209419661b6acceff45cd63984596f2e9eea517'
Cloning into '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupProject/ReactiveCocoa/Carthage/Checkouts/Quick'...
remote: Counting objects: 6235, done.
remote: Compressing objects: 100% (14/14), done.
remote: Total 6235 (delta 6), reused 0 (delta 0), pack-reused 6221
Receiving objects: 100% (6235/6235), 1.83 MiB | 1.67 MiB/s, done.
Resolving deltas: 100% (3755/3755), done.
Checking connectivity... done.
Submodule path 'ReactiveCocoa/Carthage/Checkouts/Quick': checked out 'b441ba9d4abdc87fc153c55de947834b737bbe04'
Submodule 'Externals/Nimble' (https://github.com/Quick/Nimble.git) registered for path 'ReactiveCocoa/Carthage/Checkouts/Quick/Externals/Nimble'
Cloning into '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupProject/ReactiveCocoa/Carthage/Checkouts/Quick/Externals/Nimble'...
remote: Counting objects: 5895, done.
remote: Compressing objects: 100% (2/2), done.
remote: Total 5895 (delta 0), reused 0 (delta 0), pack-reused 5893
Receiving objects: 100% (5895/5895), 1.21 MiB | 1.71 MiB/s, done.
Resolving deltas: 100% (4015/4015), done.
Checking connectivity... done.
Submodule path 'ReactiveCocoa/Carthage/Checkouts/Quick/Externals/Nimble': checked out '0209419661b6acceff45cd63984596f2e9eea517'
Cloning into '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupProject/ReactiveCocoa/Carthage/Checkouts/ReactiveSwift'...
remote: Counting objects: 40088, done.
remote: Total 40088 (delta 0), reused 0 (delta 0), pack-reused 40088
Receiving objects: 100% (40088/40088), 14.03 MiB | 2.89 MiB/s, done.
Resolving deltas: 100% (24549/24549), done.
Checking connectivity... done.
Submodule path 'ReactiveCocoa/Carthage/Checkouts/ReactiveSwift': checked out 'bc409d30ff4daa059c8904fb9b505492cc48cfbe'
Submodule 'Carthage/Checkouts/Nimble' (https://github.com/Quick/Nimble.git) registered for path 'ReactiveCocoa/Carthage/Checkouts/ReactiveSwift/Carthage/Checkouts/Nimble'
Submodule 'Carthage/Checkouts/Quick' (https://github.com/Quick/Quick.git) registered for path 'ReactiveCocoa/Carthage/Checkouts/ReactiveSwift/Carthage/Checkouts/Quick'
Submodule 'Carthage/Checkouts/Result' (https://github.com/antitypical/Result.git) registered for path 'ReactiveCocoa/Carthage/Checkouts/ReactiveSwift/Carthage/Checkouts/Result'
Submodule 'Carthage/Checkouts/xcconfigs' (https://github.com/jspahrsummers/xcconfigs.git) registered for path 'ReactiveCocoa/Carthage/Checkouts/ReactiveSwift/Carthage/Checkouts/xcconfigs'
Cloning into '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupProject/ReactiveCocoa/Carthage/Checkouts/ReactiveSwift/Carthage/Checkouts/Nimble'...
remote: Counting objects: 5895, done.
remote: Compressing objects: 100% (2/2), done.
remote: Total 5895 (delta 0), reused 0 (delta 0), pack-reused 5893
Receiving objects: 100% (5895/5895), 1.21 MiB | 1.55 MiB/s, done.
Resolving deltas: 100% (4015/4015), done.
Checking connectivity... done.
Submodule path 'ReactiveCocoa/Carthage/Checkouts/ReactiveSwift/Carthage/Checkouts/Nimble': checked out '0209419661b6acceff45cd63984596f2e9eea517'
Cloning into '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupProject/ReactiveCocoa/Carthage/Checkouts/ReactiveSwift/Carthage/Checkouts/Quick'...
remote: Counting objects: 6235, done.
remote: Compressing objects: 100% (14/14), done.
remote: Total 6235 (delta 6), reused 0 (delta 0), pack-reused 6221
Receiving objects: 100% (6235/6235), 1.83 MiB | 1.20 MiB/s, done.
Resolving deltas: 100% (3755/3755), done.
Checking connectivity... done.
Submodule path 'ReactiveCocoa/Carthage/Checkouts/ReactiveSwift/Carthage/Checkouts/Quick': checked out 'b441ba9d4abdc87fc153c55de947834b737bbe04'
Submodule 'Externals/Nimble' (https://github.com/Quick/Nimble.git) registered for path 'ReactiveCocoa/Carthage/Checkouts/ReactiveSwift/Carthage/Checkouts/Quick/Externals/Nimble'
Cloning into '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupProject/ReactiveCocoa/Carthage/Checkouts/ReactiveSwift/Carthage/Checkouts/Quick/Externals/Nimble'...
remote: Counting objects: 5895, done.
remote: Compressing objects: 100% (2/2), done.
remote: Total 5895 (delta 0), reused 0 (delta 0), pack-reused 5893
Receiving objects: 100% (5895/5895), 1.21 MiB | 1.64 MiB/s, done.
Resolving deltas: 100% (4015/4015), done.
Checking connectivity... done.
Submodule path 'ReactiveCocoa/Carthage/Checkouts/ReactiveSwift/Carthage/Checkouts/Quick/Externals/Nimble': checked out '0209419661b6acceff45cd63984596f2e9eea517'
Cloning into '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupProject/ReactiveCocoa/Carthage/Checkouts/ReactiveSwift/Carthage/Checkouts/Result'...
remote: Counting objects: 1473, done.
remote: Total 1473 (delta 0), reused 0 (delta 0), pack-reused 1473
Receiving objects: 100% (1473/1473), 257.53 KiB | 0 bytes/s, done.
Resolving deltas: 100% (774/774), done.
Checking connectivity... done.
Submodule path 'ReactiveCocoa/Carthage/Checkouts/ReactiveSwift/Carthage/Checkouts/Result': checked out 'df233a8d23a545153d5b5de13b1ac8db2503f088'
Cloning into '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupProject/ReactiveCocoa/Carthage/Checkouts/ReactiveSwift/Carthage/Checkouts/xcconfigs'...
remote: Counting objects: 679, done.
remote: Total 679 (delta 0), reused 0 (delta 0), pack-reused 679
Receiving objects: 100% (679/679), 121.34 KiB | 0 bytes/s, done.
Resolving deltas: 100% (251/251), done.
Checking connectivity... done.
Submodule path 'ReactiveCocoa/Carthage/Checkouts/ReactiveSwift/Carthage/Checkouts/xcconfigs': checked out '3d9d99634cae6d586e272543d527681283b33eb0'
Cloning into '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupProject/ReactiveCocoa/Carthage/Checkouts/Result'...
remote: Counting objects: 1473, done.
remote: Total 1473 (delta 0), reused 0 (delta 0), pack-reused 1473
Receiving objects: 100% (1473/1473), 257.53 KiB | 0 bytes/s, done.
Resolving deltas: 100% (774/774), done.
Checking connectivity... done.
Submodule path 'ReactiveCocoa/Carthage/Checkouts/Result': checked out 'df233a8d23a545153d5b5de13b1ac8db2503f088'
Cloning into '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupProject/ReactiveCocoa/Carthage/Checkouts/xcconfigs'...
remote: Counting objects: 679, done.
remote: Total 679 (delta 0), reused 0 (delta 0), pack-reused 679
Receiving objects: 100% (679/679), 121.34 KiB | 0 bytes/s, done.
Resolving deltas: 100% (251/251), done.
Checking connectivity... done.
Submodule path 'ReactiveCocoa/Carthage/Checkouts/xcconfigs': checked out '3d9d99634cae6d586e272543d527681283b33eb0'
```

**Drag and drop xcodeproj files**

![](_misc/Dragging%20and%20dropping%20xcodeproj%20files.png)

**Adding frameworks**

![](_misc/Click%20on%20the%20plus%20button%20to%20add%20frameworks%20to%20embedded%20binaries.png)

![](_misc/Selecting%20frameworks%20to%20add%20to%20Embedded%20Binaries%20section.png)

![](_misc/After%20selecting%20frameworks.png)

**Unable to find ReactiveCocoa module**

![](_misc/ReactiveCocoa%20module%20not%20found.png)
