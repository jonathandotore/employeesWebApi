import { BlobOptions } from "buffer";

export interface Employee
{
    id?: number;
    name: string;
    lastName: string;
    dept: string;
    status: boolean;
    turn: string;
    createdAt?: string;
    updatedAt?: string;
}