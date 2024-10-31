import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { User } from '../types/models/user';

@Injectable({
    providedIn: 'root'
})
export class UserService {
    private url: string = 'http://localhost:3000';

    constructor(private httpClient: HttpClient){}

    createUser(user: User): Observable<any> {
        return this.httpClient.post(this.url, user);
    }

    getAllUsers(): Observable<User[]> {
        return this.httpClient.get<User[]>(this.url);
    }

    deleteUser(): Observable<User> {
        return this.httpClient.delete<User>(this.url);
    }

    updateUser(user: User): Observable<User>{
        return this.httpClient.put<User>(this.url, user)
    }

    getUserById(userId: number): Observable<User> {
        return this.httpClient.get<User>(this.url + '/' + userId)
    }
}
