// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using EDHitchhiker.VanaheimSoftware.Api;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EDHitchhiker.VanaheimSoftware.Utils {
    public class JsonParser
    {
        // events per API event
        public event EventHandler<ApproachBody>? OnApproachBody;

        public event EventHandler<BuyExplorationData>? OnBuyExplorationData;

        public event EventHandler<CodexEntry>? OnCodexEntry;

        public event EventHandler<Commander>? OnCommander;

        public event EventHandler<DiscoveryScan>? OnDiscoveryScan;

        public event EventHandler<Docked>? OnDocked;

        public event EventHandler<DockingCancelled>? OnDockingCancelled; 

        public event EventHandler<DockingDenied>? OnDockingDenied;

        public event EventHandler<DockingGranted>? OnDockingGranted;

        public event EventHandler<DockingRequested>? OnDockingRequested;

        public event EventHandler<DockingTimeout>? OnDockingTimeout;

        public event EventHandler<FSDJump>? OnFSDJump;

        public event EventHandler<FSDTarget>? OnFSDTarget;

        public event EventHandler<FSSAllBodiesFound>? OnFSSAllBodiesFound;

        public event EventHandler<FSSDiscoveryScan>? OnFSSDiscoveryScan;

        public event EventHandler<FSSSignalDiscovered>? OnFSSSignalDiscovered;

        public event EventHandler<FuelScoop>? OnFuelScoop;

        public event EventHandler<LeaveBody>? OnLeaveBody;

        public event EventHandler<Liftoff>? OnLiftoff;

        public event EventHandler<LoadGame>? OnLoadGame;

        public event EventHandler<Loadout>? OnLoadout;

        public event EventHandler<Location>? OnLocation;

        public event EventHandler<MaterialCollected>? OnMaterialCollected;

        public event EventHandler<MaterialDiscarded>? OnMaterialDiscarded;

        public event EventHandler<MaterialDiscovered>? OnMaterialDiscovered;

        public event EventHandler<MultiSellExplorationData>? OnMultiSellExplorationData;

        public event EventHandler<Music>? OnMusic;

        public event EventHandler<NavBeaconScan>? OnNavBeaconScan;

        public event EventHandler<NavRoute>? OnNavRoute;

        public event EventHandler<NavRouteClear>? OnNavRouteClear;

        public event EventHandler<Progress>? OnProgress;

        public event EventHandler<Rank>? OnRank;

        public event EventHandler<ReceiveText>? OnReceiveText;

        public event EventHandler<Reputation>? OnReputation;

        public event EventHandler<SAAScanComplete>? OnSAAScanComplete;

        public event EventHandler<SAASignalsFound>? OnSAASignalsFound;

        public event EventHandler<Scan>? OnScan;

        public event EventHandler<ScanBaryCentre>? OnScanBaryCentre;

        public event EventHandler<Screenshot>? OnScreenshot;

        public event EventHandler<SellExplorationData>? OnSellExplorationData;

        public event EventHandler<Shutdown>? OnShutdown;

        public event EventHandler<StartJump>? OnStartJump;

        public event EventHandler<SupercruiseEntry>? OnSupercruiseEntry;

        public event EventHandler<SupercruiseExit>? OnSupercruiseExit;

        public event EventHandler<Touchdown>? OnTouchdown;

        public event EventHandler<Undocked>? OnUndocked;

        /**
         * Based of Journal version: 37
         * Link: https://hosting.zaonce.net/community/journal/v37/Journal_Manual_v37.pdf
         * Note: As of 2025/04/05 still no updated journal including PP2.0 and Colonization. I may manually update as I fiddle around
         *       Not all event entries and fields is encountered for in this parser
         */
        public void Parse(string? json)
        {
            if (string.IsNullOrWhiteSpace(json)) return;    // todo - add logging if I care

            BaseEvent? baseEvent = JsonConvert.DeserializeObject<BaseEvent>(json);
            if (baseEvent == null || string.IsNullOrWhiteSpace(baseEvent.EventType)) return;

            switch (baseEvent.EventType.ToLower())
            {
                case "approachbody":
                    ApproachBody? approachBody = JsonConvert.DeserializeObject<ApproachBody>(json);
                    if (approachBody != null)
                        OnApproachBody?.Invoke(this, approachBody);
                    break;

                case "buyexplorationdata":
                    BuyExplorationData? buyExplorationData = JsonConvert.DeserializeObject<BuyExplorationData>(json);
                    if (buyExplorationData != null)
                        OnBuyExplorationData?.Invoke(this, buyExplorationData);
                    break;

                case "codexentry":
                    CodexEntry? codexEntry = JsonConvert.DeserializeObject<CodexEntry>(json);
                    if (codexEntry != null)
                        OnCodexEntry?.Invoke(this, codexEntry);
                    break;

                case "commander":
                    Commander? commander = JsonConvert.DeserializeObject<Commander>(json);
                    if (commander != null)
                        OnCommander?.Invoke(this, commander);
                    break;

                case "discoveryscan":
                    DiscoveryScan? discoveryScan = JsonConvert.DeserializeObject<DiscoveryScan>(json);
                    if (discoveryScan != null)
                        OnDiscoveryScan?.Invoke(this, discoveryScan);
                    break;

                case "docked":
                    Docked? docked = JsonConvert.DeserializeObject<Docked>(json);
                    if (docked != null)
                        OnDocked?.Invoke(this, docked);
                    break;

                case "dockingcancelled":
                    DockingCancelled? dockingCancelled = JsonConvert.DeserializeObject<DockingCancelled>(json);
                    if (dockingCancelled != null)
                        OnDockingCancelled?.Invoke(this, dockingCancelled);
                    break;

                case "dockingdenied":
                    DockingDenied? dockingDenied = JsonConvert.DeserializeObject<DockingDenied>(json);
                    if (dockingDenied != null)
                        OnDockingDenied?.Invoke(this, dockingDenied);
                    break;

                case "dockinggranted":
                    DockingGranted? dockingGranted = JsonConvert.DeserializeObject<DockingGranted>(json);
                    if (dockingGranted != null)
                        OnDockingGranted?.Invoke(this, dockingGranted);
                    break;

                case "dockingrequested":
                    DockingRequested? dockingRequested = JsonConvert.DeserializeObject<DockingRequested>(json);
                    if (dockingRequested != null)
                        OnDockingRequested?.Invoke(this, dockingRequested);
                    break;

                case "dockingtimeout":
                    DockingTimeout? dockingTimeout = JsonConvert.DeserializeObject<DockingTimeout>(json);
                    if (dockingTimeout != null)
                        OnDockingTimeout?.Invoke(this, dockingTimeout);
                    break;

                case "fsdjump":
                    FSDJump? fsdJump = JsonConvert.DeserializeObject<FSDJump>(json);
                    if (fsdJump != null)
                        OnFSDJump?.Invoke(this, fsdJump);
                    break;

                case "fsdtarget":
                    FSDTarget? fsdTarget = JsonConvert.DeserializeObject<FSDTarget>(json);
                    if (fsdTarget != null)
                        OnFSDTarget?.Invoke(this, fsdTarget);
                    break;

                case "fssallbodiesfound":
                    FSSAllBodiesFound? allBodiesFound = JsonConvert.DeserializeObject<FSSAllBodiesFound>(json);
                    if (allBodiesFound != null)
                        OnFSSAllBodiesFound?.Invoke(this, allBodiesFound);
                    break;

                case "fssdiscoveryscan":
                    FSSDiscoveryScan? fssDiscoveryScan = JsonConvert.DeserializeObject<FSSDiscoveryScan>(json);
                    if (fssDiscoveryScan != null)
                        OnFSSDiscoveryScan?.Invoke(this, fssDiscoveryScan);
                    break;

                case "fsssignaldiscovered":
                    FSSSignalDiscovered? fssSignalDiscovered = JsonConvert.DeserializeObject<FSSSignalDiscovered>(json);
                    if (fssSignalDiscovered != null)
                        OnFSSSignalDiscovered?.Invoke(this, fssSignalDiscovered);
                    break;

                case "fuelscoop":
                    FuelScoop? fuelScoop = JsonConvert.DeserializeObject<FuelScoop>(json);
                    if (fuelScoop != null)
                        OnFuelScoop?.Invoke(this, fuelScoop);
                    break;

                case "leavebody":
                    LeaveBody? leaveBody = JsonConvert.DeserializeObject<LeaveBody>(json);
                    if (leaveBody != null)
                        OnLeaveBody?.Invoke(this, leaveBody);
                    break;

                case "liftoff":
                    Liftoff? liftoff = JsonConvert.DeserializeObject<Liftoff>(json);
                    if (liftoff != null)
                        OnLiftoff?.Invoke(this, liftoff);
                    break;

                case "loadgame":
                    LoadGame? loadGame = JsonConvert.DeserializeObject<LoadGame>(json);
                    if (loadGame != null)
                        OnLoadGame?.Invoke(this, loadGame);
                    break;

                case "loadout":
                    Loadout? loadout = JsonConvert.DeserializeObject<Loadout>(json);
                    if (loadout != null)
                        OnLoadout?.Invoke(this, loadout);
                    break;

                case "location":
                    Location? location = JsonConvert.DeserializeObject<Location>(json);
                    if (location != null)
                        OnLocation?.Invoke(this, location);
                    break;

                case "materialcollected":
                    MaterialCollected? materialCollected = JsonConvert.DeserializeObject<MaterialCollected>(json);
                    if (materialCollected != null)
                        OnMaterialCollected?.Invoke(this, materialCollected);
                    break;

                case "materialdiscarded":
                    MaterialDiscarded? materialDiscarded = JsonConvert.DeserializeObject<MaterialDiscarded>(json);
                    if (materialDiscarded != null)
                        OnMaterialDiscarded?.Invoke(this, materialDiscarded);
                    break;

                case "materialdiscovered":
                    MaterialDiscovered? materialDiscovered = JsonConvert.DeserializeObject<MaterialDiscovered>(json);
                    if (materialDiscovered != null)
                        OnMaterialDiscovered?.Invoke(this, materialDiscovered);
                    break;

                case "multisellexplorationdata":
                    MultiSellExplorationData? multiSellExplorationData = JsonConvert.DeserializeObject<MultiSellExplorationData>(json);
                    if (multiSellExplorationData != null)
                        OnMultiSellExplorationData?.Invoke(this, multiSellExplorationData);
                    break;

                case "music":
                    Music? music = JsonConvert.DeserializeObject<Music>(json);
                    if (music != null)
                        OnMusic?.Invoke(this, music);
                    break;

                case "navbeaconscan":
                    NavBeaconScan? navBeaconScan = JsonConvert.DeserializeObject<NavBeaconScan>(json);
                    if (navBeaconScan != null)
                        OnNavBeaconScan?.Invoke(this, navBeaconScan);
                    break;

                case "navroute":
                    NavRoute? navRoute = JsonConvert.DeserializeObject<NavRoute>(json);
                    if (navRoute != null)
                        OnNavRoute?.Invoke(this, navRoute);
                    break;

                case "navrouteclear":
                    NavRouteClear? navRouteClear = JsonConvert.DeserializeObject<NavRouteClear>(json);
                    if (navRouteClear != null)
                        OnNavRouteClear?.Invoke(this, navRouteClear);
                    break;

                case "progress":
                    Progress? progress = JsonConvert.DeserializeObject<Progress>(json);
                    if (progress != null)
                        OnProgress?.Invoke(this, progress);
                    break;

                case "rank":
                    Rank? rank = JsonConvert.DeserializeObject<Rank>(json);
                    if (rank != null)
                        OnRank?.Invoke(this, rank);
                    break;

                case "receivetext":
                    ReceiveText? receiveText = JsonConvert.DeserializeObject<ReceiveText>(json);
                    if (receiveText != null)
                        OnReceiveText?.Invoke(this, receiveText);
                    break;

                case "reputation":
                    Reputation? reputation = JsonConvert.DeserializeObject<Reputation>(json);
                    if (reputation != null)
                        OnReputation?.Invoke(this, reputation);
                    break;

                case "saascancomplete":
                    SAAScanComplete? saaScanComplete = JsonConvert.DeserializeObject<SAAScanComplete>(json);
                    if (saaScanComplete != null)
                        OnSAAScanComplete?.Invoke(this, saaScanComplete);
                    break;

                case "saasignalsfound":
                    SAASignalsFound? saaSignalsFound = JsonConvert.DeserializeObject<SAASignalsFound>(json);
                    if (saaSignalsFound != null)
                        OnSAASignalsFound?.Invoke(this, saaSignalsFound);
                    break;

                case "scan":
                    Scan? scan = JsonConvert.DeserializeObject<Scan>(json, new ListKeyValuePairIntConverter());
                    if (scan != null)
                        OnScan?.Invoke(this, scan);
                    break;

                case "scanbarycentre":
                    ScanBaryCentre? scanBaryCentre = JsonConvert.DeserializeObject<ScanBaryCentre>(json);
                    if (scanBaryCentre != null)
                        OnScanBaryCentre?.Invoke(this, scanBaryCentre);
                    break;

                case "screenshot":
                    Screenshot? screenshot = JsonConvert.DeserializeObject<Screenshot>(json);
                    if (screenshot != null)
                        OnScreenshot?.Invoke(this, screenshot);
                    break;

                case "sellexplorationdata":
                    SellExplorationData? sellExplorationData = JsonConvert.DeserializeObject<SellExplorationData>(json);
                    if (sellExplorationData != null)
                        OnSellExplorationData?.Invoke(this, sellExplorationData);
                    break;

                case "shutdown":
                    Shutdown? shutdown = JsonConvert.DeserializeObject<Shutdown>(json);
                    if (shutdown != null)
                        OnShutdown?.Invoke(this, shutdown);
                    break;

                case "startjump":
                    StartJump? startJump = JsonConvert.DeserializeObject<StartJump>(json);
                    if (startJump != null)
                        OnStartJump?.Invoke(this, startJump);
                    break;

                case "supercruiseentry":
                    SupercruiseEntry? supercruiseEntry = JsonConvert.DeserializeObject<SupercruiseEntry>(json);
                    if (supercruiseEntry != null)
                        OnSupercruiseEntry?.Invoke(this, supercruiseEntry);
                    break;

                case "supercruiseexit":
                    SupercruiseExit? supercruiseExit = JsonConvert.DeserializeObject<SupercruiseExit>(json);
                    if (supercruiseExit != null)
                        OnSupercruiseExit?.Invoke(this, supercruiseExit);
                    break;

                case "touchdown":
                    Touchdown? touchdown = JsonConvert.DeserializeObject<Touchdown>(json);
                    if (touchdown != null)
                        OnTouchdown?.Invoke(this, touchdown);
                    break;

                case "undocked":
                    Undocked? undocked = JsonConvert.DeserializeObject<Undocked>(json);
                    if (undocked != null)
                        OnUndocked?.Invoke(this, undocked);
                    break;

                default:
                    // no default, just ignore unsupported
                    break;
            }
        }

        protected class ListKeyValuePairIntConverter : JsonConverter
        {
            public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
            {
                // ignore - only deserializing 
            }

            public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
            {
                IList<KeyValuePair<string, int>>? target = null;

                var jsonArray = JArray.Load(reader);

                if (jsonArray != null && jsonArray.Count > 0)
                {
                    target = [];

                    foreach (var e in jsonArray)
                    {
                        var d = e.ToObject<Dictionary<string, int>>();
                        if (d != null && d.Count == 1)
                        {
                            target.Add(d.First());
                        }
                    }
                }

                return target;
            }


            public override bool CanConvert(Type objectType)
            {
                return objectType == typeof(IList<KeyValuePair<string, int>>);
            }
        }
    }
}

