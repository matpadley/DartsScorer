//
//  Leg_Tests.swift
//  DartsEngine.Tests
//
//  Created by Mathew Padley on 11/09/2024.
//

import XCTest

class Leg_Tests: XCTestCase
{
    func testPlayerInitialization() {
        
        
    }
    
    func legInitTests()
    {
        let leg = Leg()
        XCTAssertEqual(leg.Score, 0, "Leg should have no score on initialisation")
        XCTAssertEqual(leg.Throws.count, 0, "Leg should have no throws")
    }
}
