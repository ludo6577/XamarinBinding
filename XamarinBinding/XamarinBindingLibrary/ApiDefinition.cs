using Foundation;
using System;
using AVFoundation;
using CloudKit;
using CoreAnimation;
using CoreData;
using CoreFoundation;
using CoreGraphics;
using CoreImage;
using CoreLocation;
using CoreText;
using CoreVideo;
using FileProvider;
using Foundation;
using IOSurface;
using ImageIO;
using Intents;
using Metal;
using ObjCRuntime;
using OpenGLES;
using Security;
using UIKit;

namespace XamarinBindingLibrary
{
    //// @interface ATInternet : NSObject
    [BaseType(typeof(NSObject))]
    //[DisableDefaultCtor]
    public interface ATInternet
    {
        // @property (readonly, nonatomic, strong) Tracker * _Nonnull defaultTracker;
        [Export("defaultTracker", ArgumentSemantic.Strong)]
        Tracker DefaultTracker { get; }

        // @property (readonly, nonatomic, strong, class) ATInternet * _Nonnull sharedInstance;
        [Static]
        [Export("sharedInstance")]
        ATInternet SharedInstance();

        // -(Tracker * _Nonnull)tracker:(NSString * _Nonnull)name __attribute__((warn_unused_result));
        [Export("tracker:")]
        Tracker Tracker(string name);
    }

    // @interface Tracker : NSObject
    [BaseType(typeof(NSObject))]
    public interface Tracker
    {
        // -(void)setConfig:(NSDictionary<NSString *,NSString *> * _Nonnull)configuration override:(BOOL)override sync:(BOOL)sync completionHandler:(void (^ _Nullable)(BOOL))completionHandler;
        [Export("setConfig:override:sync:completionHandler:")]
        void SetConfig(NSDictionary<NSString, NSString> configuration, bool @override, bool sync, [NullAllowed] Action<bool> completionHandler);
    }
}
