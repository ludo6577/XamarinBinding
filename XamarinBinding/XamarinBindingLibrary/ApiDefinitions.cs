using System;
using AVFoundation;
using CloudKit;
//using CoreAnimation;
using CoreData;
using CoreFoundation;
using CoreGraphics;
using CoreImage;
using CoreLocation;
using CoreText;
using CoreVideo;
//using Darwin;
//using Dispatch;
using FileProvider;
using Foundation;
using IOSurface;
using ImageIO;
using Intents;
using Metal;
using ObjCRuntime;
//using ObjectiveC;
using OpenGLES;
using Security;
using UIKit;

namespace XamarinBindingLibrary
{


    // @interface ATInternet : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC7Tracker10ATInternet")]
    [DisableDefaultCtor]
    interface ATInternet
    {
        // @property (readonly, nonatomic, strong) Tracker * _Nonnull defaultTracker;
        [Export("defaultTracker", ArgumentSemantic.Strong)]
        Tracker DefaultTracker { get; }

        // @property (readonly, nonatomic, strong, class) ATInternet * _Nonnull sharedInstance;
        [Static]
        [Export("sharedInstance", ArgumentSemantic.Strong)]
        ATInternet SharedInstance { get; }

        // -(Tracker * _Nonnull)tracker:(NSString * _Nonnull)name __attribute__((warn_unused_result));
        [Export("tracker:")]
        Tracker Tracker(string name);

        //// -(Tracker * _Nonnull)tracker:(NSString * _Nonnull)name configuration:(NSDictionary<NSString *,NSString *> * _Nonnull)configuration __attribute__((warn_unused_result));
        //[Export("tracker:configuration:")]
        //Tracker Tracker(string name, NSDictionary<NSString, NSString> configuration);
    }

    //[BaseType(typeof(Tracker))]
    //[DisableDefaultCtor]
    //interface AutoTracker
    //{
    //    // @property (copy, nonatomic) NSString * _Nullable token;
    //    [NullAllowed, Export("token")]
    //    string Token { get; set; }

    //    // @property (nonatomic) BOOL enableLiveTagging;
    //    [Export("enableLiveTagging")]
    //    bool EnableLiveTagging { get; set; }

    //    // @property (nonatomic) BOOL enableAutoTracking;
    //    [Export("enableAutoTracking")]
    //    bool EnableAutoTracking { get; set; }
    //}

    // @interface Tracker : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC7Tracker7Tracker")]
    interface Tracker
    {
        //[Wrap("WeakDelegate")]
        //[NullAllowed]
        //TrackerDelegate Delegate { get; set; }

        //// @property (nonatomic, strong) id<TrackerDelegate> _Nullable delegate;
        //[NullAllowed, Export("delegate", ArgumentSemantic.Strong)]
        //NSObject WeakDelegate { get; set; }

        //// @property (nonatomic) BOOL enableDebugger;
        //[Export("enableDebugger")]
        //bool EnableDebugger { get; set; }

        //// @property (readonly, nonatomic, strong) Offline * _Nonnull offline;
        //[Export("offline", ArgumentSemantic.Strong)]
        //Offline Offline { get; }

        //// @property (readonly, nonatomic, strong) Context * _Nonnull context;
        //[Export("context", ArgumentSemantic.Strong)]
        //Context Context { get; }

        //// @property (readonly, nonatomic, strong) NuggAds * _Nonnull nuggAds;
        //[Export("nuggAds", ArgumentSemantic.Strong)]
        //NuggAds NuggAds { get; }

        //// @property (readonly, nonatomic, strong) Locations * _Nonnull locations;
        //[Export("locations", ArgumentSemantic.Strong)]
        //Locations Locations { get; }

        //// @property (readonly, nonatomic, strong) Publishers * _Nonnull publishers;
        //[Export("publishers", ArgumentSemantic.Strong)]
        //Publishers Publishers { get; }

        //// @property (readonly, nonatomic, strong) SelfPromotions * _Nonnull selfPromotions;
        //[Export("selfPromotions", ArgumentSemantic.Strong)]
        //SelfPromotions SelfPromotions { get; }

        //// @property (readonly, nonatomic, strong) IdentifiedVisitor * _Nonnull identifiedVisitor;
        //[Export("identifiedVisitor", ArgumentSemantic.Strong)]
        //IdentifiedVisitor IdentifiedVisitor { get; }

        //// @property (readonly, nonatomic, strong) Screens * _Nonnull screens;
        //[Export("screens", ArgumentSemantic.Strong)]
        //Screens Screens { get; }

        //// @property (readonly, nonatomic, strong) DynamicScreens * _Nonnull dynamicScreens;
        //[Export("dynamicScreens", ArgumentSemantic.Strong)]
        //DynamicScreens DynamicScreens { get; }

        //// @property (readonly, nonatomic, strong) Gestures * _Nonnull gestures;
        //[Export("gestures", ArgumentSemantic.Strong)]
        //Gestures Gestures { get; }

        //// @property (readonly, nonatomic, strong) CustomObjects * _Nonnull customObjects;
        //[Export("customObjects", ArgumentSemantic.Strong)]
        //CustomObjects CustomObjects { get; }

        //// @property (readonly, nonatomic, strong) CustomVars * _Nonnull customVars;
        //[Export("customVars", ArgumentSemantic.Strong)]
        //CustomVars CustomVars { get; }

        //// @property (readonly, nonatomic, strong) Orders * _Nonnull orders;
        //[Export("orders", ArgumentSemantic.Strong)]
        //Orders Orders { get; }

        //// @property (readonly, nonatomic, strong) Cart * _Nonnull cart;
        //[Export("cart", ArgumentSemantic.Strong)]
        //Cart Cart { get; }

        //// @property (readonly, nonatomic, strong) Products * _Nonnull products;
        //[Export("products", ArgumentSemantic.Strong)]
        //Products Products { get; }

        //// @property (readonly, nonatomic, strong) Campaigns * _Nonnull campaigns;
        //[Export("campaigns", ArgumentSemantic.Strong)]
        //Campaigns Campaigns { get; }

        //// @property (readonly, nonatomic, strong) InternalSearches * _Nonnull internalSearches;
        //[Export("internalSearches", ArgumentSemantic.Strong)]
        //InternalSearches InternalSearches { get; }

        //// @property (readonly, nonatomic, strong) CustomTreeStructures * _Nonnull customTreeStructures;
        //[Export("customTreeStructures", ArgumentSemantic.Strong)]
        //CustomTreeStructures CustomTreeStructures { get; }

        //// @property (readonly, nonatomic, strong) MediaPlayers * _Nonnull mediaPlayers;
        //[Export("mediaPlayers", ArgumentSemantic.Strong)]
        //MediaPlayers MediaPlayers { get; }

        //// -(instancetype _Nonnull)initWithConfiguration:(NSDictionary<NSString *,NSString *> * _Nonnull)configuration __attribute__((objc_designated_initializer));
        //[Export("initWithConfiguration:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSDictionary<NSString, NSString> configuration);

        //// @property (readonly, copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nonnull config;
        //[Export("config", ArgumentSemantic.Copy)]
        //NSDictionary<NSString, NSString> Config { get; }

        //// -(void)setConfig:(NSDictionary<NSString *,NSString *> * _Nonnull)configuration override:(BOOL)override sync:(BOOL)sync completionHandler:(void (^ _Nullable)(BOOL))completionHandler;
        //[Export("setConfig:override:sync:completionHandler:")]
        //void SetConfig(NSDictionary<NSString, NSString> configuration, bool @override, bool sync, [NullAllowed] Action<bool> completionHandler);

        //// -(void)setConfig:(NSString * _Nonnull)key value:(NSString * _Nonnull)value sync:(BOOL)sync completionHandler:(void (^ _Nullable)(BOOL))completionHandler;
        //[Export("setConfig:value:sync:completionHandler:")]
        //void SetConfig(string key, string value, bool sync, [NullAllowed] Action<bool> completionHandler);

        //// -(void)setLog:(NSString * _Nonnull)log sync:(BOOL)sync completionHandler:(void (^ _Nullable)(BOOL))completionHandler;
        //[Export("setLog:sync:completionHandler:")]
        //void SetLog(string log, bool sync, [NullAllowed] Action<bool> completionHandler);

        //// -(void)setSecuredLog:(NSString * _Nonnull)securedLog sync:(BOOL)sync completionHandler:(void (^ _Nullable)(BOOL))completionHandler;
        //[Export("setSecuredLog:sync:completionHandler:")]
        //void SetSecuredLog(string securedLog, bool sync, [NullAllowed] Action<bool> completionHandler);

        //// -(void)setDomain:(NSString * _Nonnull)domain sync:(BOOL)sync completionHandler:(void (^ _Nullable)(BOOL))completionHandler;
        //[Export("setDomain:sync:completionHandler:")]
        //void SetDomain(string domain, bool sync, [NullAllowed] Action<bool> completionHandler);

        //// -(void)setSiteId:(NSInteger)siteId sync:(BOOL)sync completionHandler:(void (^ _Nullable)(BOOL))completionHandler;
        //[Export("setSiteId:sync:completionHandler:")]
        //void SetSiteId(nint siteId, bool sync, [NullAllowed] Action<bool> completionHandler);

        //// -(void)setSecureModeEnabled:(BOOL)enabled sync:(BOOL)sync completionHandler:(void (^ _Nullable)(BOOL))completionHandler;
        //[Export("setSecureModeEnabled:sync:completionHandler:")]
        //void SetSecureModeEnabled(bool enabled, bool sync, [NullAllowed] Action<bool> completionHandler);

        //// -(void)setHashUserIdEnabled:(BOOL)enabled sync:(BOOL)sync completionHandler:(void (^ _Nullable)(BOOL))completionHandler;
        //[Export("setHashUserIdEnabled:sync:completionHandler:")]
        //void SetHashUserIdEnabled(bool enabled, bool sync, [NullAllowed] Action<bool> completionHandler);

        //// -(void)setBackgroundTaskEnabled:(BOOL)enabled sync:(BOOL)sync completionHandler:(void (^ _Nullable)(BOOL))completionHandler;
        //[Export("setBackgroundTaskEnabled:sync:completionHandler:")]
        //void SetBackgroundTaskEnabled(bool enabled, bool sync, [NullAllowed] Action<bool> completionHandler);

        //// -(void)setPixelPath:(NSString * _Nonnull)pixelPath sync:(BOOL)sync completionHandler:(void (^ _Nullable)(BOOL))completionHandler;
        //[Export("setPixelPath:sync:completionHandler:")]
        //void SetPixelPath(string pixelPath, bool sync, [NullAllowed] Action<bool> completionHandler);

        //// -(void)setPersistentIdentifiedVisitorEnabled:(BOOL)enabled sync:(BOOL)sync completionHandler:(void (^ _Nullable)(BOOL))completionHandler;
        //[Export("setPersistentIdentifiedVisitorEnabled:sync:completionHandler:")]
        //void SetPersistentIdentifiedVisitorEnabled(bool enabled, bool sync, [NullAllowed] Action<bool> completionHandler);

        //// -(void)setCampaignLastPersistenceEnabled:(BOOL)enabled sync:(BOOL)sync completionHandler:(void (^ _Nullable)(BOOL))completionHandler;
        //[Export("setCampaignLastPersistenceEnabled:sync:completionHandler:")]
        //void SetCampaignLastPersistenceEnabled(bool enabled, bool sync, [NullAllowed] Action<bool> completionHandler);

        //// -(void)setCampaignLifetime:(NSInteger)lifetime sync:(BOOL)sync completionHandler:(void (^ _Nullable)(BOOL))completionHandler;
        //[Export("setCampaignLifetime:sync:completionHandler:")]
        //void SetCampaignLifetime(nint lifetime, bool sync, [NullAllowed] Action<bool> completionHandler);

        //// -(void)setSessionBackgroundDuration:(NSInteger)duration sync:(BOOL)sync completionHandler:(void (^ _Nullable)(BOOL))completionHandler;
        //[Export("setSessionBackgroundDuration:sync:completionHandler:")]
        //void SetSessionBackgroundDuration(nint duration, bool sync, [NullAllowed] Action<bool> completionHandler);

        //// -(Tracker * _Nonnull)setParam:(NSString * _Nonnull)key value:(NSString * _Nonnull (^ _Nonnull)(void))value;
        //[Export("setParam:value:")]
        //Tracker SetParam(string key, Func<NSString> value);

        //// -(Tracker * _Nonnull)setParam:(NSString * _Nonnull)key value:(NSString * _Nonnull (^ _Nonnull)(void))value options:(ParamOption * _Nonnull)options;
        //[Export("setParam:value:options:")]
        //Tracker SetParam(string key, Func<NSString> value, ParamOption options);

        //// -(Tracker * _Nonnull)setStringParam:(NSString * _Nonnull)key value:(NSString * _Nonnull)value;
        //[Export("setStringParam:value:")]
        //Tracker SetStringParam(string key, string value);

        //// -(Tracker * _Nonnull)setStringParam:(NSString * _Nonnull)key value:(NSString * _Nonnull)value options:(ParamOption * _Nonnull)options;
        //[Export("setStringParam:value:options:")]
        //Tracker SetStringParam(string key, string value, ParamOption options);

        //// -(Tracker * _Nonnull)setIntParam:(NSString * _Nonnull)key value:(NSInteger)value;
        //[Export("setIntParam:value:")]
        //Tracker SetIntParam(string key, nint value);

        //// -(Tracker * _Nonnull)setIntParam:(NSString * _Nonnull)key value:(NSInteger)value options:(ParamOption * _Nonnull)options;
        //[Export("setIntParam:value:options:")]
        //Tracker SetIntParam(string key, nint value, ParamOption options);

        //// -(Tracker * _Nonnull)setFloatParam:(NSString * _Nonnull)key value:(float)value;
        //[Export("setFloatParam:value:")]
        //Tracker SetFloatParam(string key, float value);

        //// -(Tracker * _Nonnull)setFloatParam:(NSString * _Nonnull)key value:(float)value options:(ParamOption * _Nonnull)options;
        //[Export("setFloatParam:value:options:")]
        //Tracker SetFloatParam(string key, float value, ParamOption options);

        //// -(Tracker * _Nonnull)setDoubleParam:(NSString * _Nonnull)key value:(double)value;
        //[Export("setDoubleParam:value:")]
        //Tracker SetDoubleParam(string key, double value);

        //// -(Tracker * _Nonnull)setDoubleParam:(NSString * _Nonnull)key value:(double)value options:(ParamOption * _Nonnull)options;
        //[Export("setDoubleParam:value:options:")]
        //Tracker SetDoubleParam(string key, double value, ParamOption options);

        //// -(Tracker * _Nonnull)setBoolParam:(NSString * _Nonnull)key value:(BOOL)value;
        //[Export("setBoolParam:value:")]
        //Tracker SetBoolParam(string key, bool value);

        //// -(Tracker * _Nonnull)setBoolParam:(NSString * _Nonnull)key value:(BOOL)value options:(ParamOption * _Nonnull)options;
        //[Export("setBoolParam:value:options:")]
        //Tracker SetBoolParam(string key, bool value, ParamOption options);

        //// -(Tracker * _Nonnull)setArrayParam:(NSString * _Nonnull)key value:(NSArray * _Nonnull)value;
        //[Export("setArrayParam:value:")]
        //Tracker SetArrayParam(string key, NSObject[] value);

        //// -(Tracker * _Nonnull)setArrayParam:(NSString * _Nonnull)key value:(NSArray * _Nonnull)value options:(ParamOption * _Nonnull)options;
        //[Export("setArrayParam:value:options:")]
        //Tracker SetArrayParam(string key, NSObject[] value, ParamOption options);

        //// -(Tracker * _Nonnull)setDictionaryParam:(NSString * _Nonnull)key value:(NSDictionary<NSString *,id> * _Nonnull)value;
        //[Export("setDictionaryParam:value:")]
        //Tracker SetDictionaryParam(string key, NSDictionary<NSString, NSObject> value);

        //// -(Tracker * _Nonnull)setDictionaryParam:(NSString * _Nonnull)key value:(NSDictionary<NSString *,id> * _Nonnull)value options:(ParamOption * _Nonnull)options;
        //[Export("setDictionaryParam:value:options:")]
        //Tracker SetDictionaryParam(string key, NSDictionary<NSString, NSObject> value, ParamOption options);

        //// -(void)unsetParam:(NSString * _Nonnull)param;
        //[Export("unsetParam:")]
        //void UnsetParam(string param);

        //// -(void)resetScreenContext;
        //[Export("resetScreenContext")]
        //void ResetScreenContext();

        //// -(void)dispatch;
        //[Export("dispatch")]
        //void Dispatch();

        //// -(NSString * _Nonnull)getUserId __attribute__((warn_unused_result));
        //[Export("getUserId")]
        //string UserId { get; }

        //// -(void)setUserIdWithUserId:(NSString * _Nonnull)userId;
        //[Export("setUserIdWithUserId:")]
        //void SetUserIdWithUserId(string userId);

        //// @property (nonatomic, class) BOOL doNotTrack;
        //[Static]
        //[Export("doNotTrack")]
        //bool DoNotTrack { get; set; }

        //// @property (nonatomic, class) BOOL handleCrash;
        //[Static]
        //[Export("handleCrash")]
        //bool HandleCrash { get; set; }
    }

}