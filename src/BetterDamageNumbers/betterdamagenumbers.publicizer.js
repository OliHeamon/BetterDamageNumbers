import {createPublicizer} from "publicizer";

export const publicizer = createPublicizer("BetterDamageNumbers");

publicizer.createAssembly("tModLoader").publicizeAll();