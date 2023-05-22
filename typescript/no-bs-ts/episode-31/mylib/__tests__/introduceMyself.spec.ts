import { introduceMyself } from "../src/index";

describe("My first jest test with TypesScript (introduceMySelf)", () => {
    it("should display a friendly greeting", () => {
        expect(introduceMyself("Larry", "Jones")).toEqual("Hello, Larry Jones")
    })
})