### Project Creation

macOS Sierra Version 10.12 (16A323)

Xcode Version 8.0 (8A218a)

The instructions specified at https://github.com/ReactiveCocoa/ReactiveCocoa are

```
Or, if you’re using Carthage, simply add ReactiveCocoa to your Cartfile:

github "ReactiveCocoa/ReactiveCocoa"

Make sure to add ReactiveCocoa.framework, ReactiveSwift, and Result.framework to "Linked Frameworks and Libraries" and "copy-frameworks" Build Phases.
```

**Setup Carthage**

https://github.com/Carthage/Carthage/releases

**Create a Cartfile**

*RACSetupWithCarthage/Cartfile*

```
github "ReactiveCocoa/ReactiveCocoa"
```

```sh
droid@Yamz:~/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage$ which carthage
/usr/local/bin/carthage
droid@Yamz:~/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage$ carthage update
*** Fetching ReactiveCocoa
*** Fetching Result
*** Checking out Result at "2.1.3"
*** Checking out ReactiveCocoa at "v4.2.2"
*** xcodebuild output can be found in /var/folders/d2/2_rpvswn6w5c8mrz4swfvt4c0000gp/T/carthage-xcodebuild.dkrpdb.log
*** Building scheme "Result-iOS" in Result.xcodeproj
*** Building scheme "Result-Mac" in Result.xcodeproj
*** Building scheme "Result-tvOS" in Result.xcodeproj
*** Building scheme "Result-watchOS" in Result.xcodeproj
*** Building scheme "ReactiveCocoa-iOS" in ReactiveCocoa.xcworkspace
--- xcodebuild: WARNING: Unable to open project file '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa.playground' in workspace '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa.xcworkspace'.
--- xcodebuild: WARNING: Unable to open project file '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa.playground' in workspace '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa.xcworkspace'.
--- xcodebuild: WARNING: Unable to open project file '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa.playground' in workspace '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa.xcworkspace'.
--- xcodebuild: WARNING: Unable to open project file '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa.playground' in workspace '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa.xcworkspace'.
*** Building scheme "ReactiveCocoa-tvOS" in ReactiveCocoa.xcworkspace
--- xcodebuild: WARNING: Unable to open project file '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa.playground' in workspace '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa.xcworkspace'.
--- xcodebuild: WARNING: Unable to open project file '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa.playground' in workspace '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa.xcworkspace'.
--- xcodebuild: WARNING: Unable to open project file '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa.playground' in workspace '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa.xcworkspace'.
--- xcodebuild: WARNING: Unable to open project file '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa.playground' in workspace '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa.xcworkspace'.
*** Building scheme "ReactiveCocoa-Mac" in ReactiveCocoa.xcworkspace
--- xcodebuild: WARNING: Unable to open project file '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa.playground' in workspace '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa.xcworkspace'.
--- xcodebuild: WARNING: Unable to open project file '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa.playground' in workspace '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa.xcworkspace'.
*** Building scheme "ReactiveCocoa-watchOS" in ReactiveCocoa.xcworkspace
--- xcodebuild: WARNING: Unable to open project file '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa.playground' in workspace '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa.xcworkspace'.
--- xcodebuild: WARNING: Unable to open project file '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa.playground' in workspace '/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa.xcworkspace'.
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
/Users/droid/onGit/Reactive-Programming-Examples/ReactiveCocoa/RACSetupWithCarthage/Carthage/Checkouts/ReactiveCocoa/ReactiveCocoa/Swift/SignalProducer.swift:1945:69: warning: 'buffer' is deprecated: Use properties instead. 'buffer' will be removed in RAC 5.0
```
