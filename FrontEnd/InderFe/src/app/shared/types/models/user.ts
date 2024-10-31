import { Gender } from "./gender";

export interface User {
    id: number;
    name: string;
    surname: string;
    age: number;
    height: number;
    weight: number;
    gender: Gender;
    lookingFor: Gender;
    bio: string;
    profilePic: string;
}