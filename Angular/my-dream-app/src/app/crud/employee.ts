export class Employee {
    public constructor(init?: Partial<Employee>) {
        Object.assign(this, init);
    }
    Name:string;
    EmployeeId:number;
}
