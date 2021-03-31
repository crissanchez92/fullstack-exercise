import { Address } from "./address";

export interface Property {
    id: number;
    propertyID: number;
    listPrice: number;
    monthlyRent: number;
    grossYield: number;
    yearBuilt: number;
    address: Address;
}