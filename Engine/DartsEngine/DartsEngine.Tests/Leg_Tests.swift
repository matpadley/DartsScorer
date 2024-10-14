//
//  Leg_Tests.swift
//  DartsEngine.Tests
//
//  Created by Mathew Padley on 11/09/2024.
//

import XCTest
@testable import DartsEngine

class Leg_Tests: XCTestCase
{
    func testPlayerInitialization() {
        
        
    }
    
    func testlegInit()
    {
        let leg = Leg()
        XCTAssertEqual(leg.Score, 0, "Leg should have no score on initialisation")
        XCTAssertEqual(leg.Throws.count, 0, "Leg should have no throws")
    }
    
    func testAddScore()
    {
        let leg = Leg()
        XCTAssertNoThrow(try leg.addScore(score: 12))
        XCTAssertEqual(leg.Throws.count, 1, "Leg should have one score")
    }
    
    func testAddFourScores_ShouldThrowException()
    {
        let leg = Leg()
        XCTAssertNoThrow(try leg.addScore(score: 12))
        XCTAssertNoThrow(try leg.addScore(score: 12))
        XCTAssertNoThrow(try leg.addScore(score: 12))
        XCTAssertThrowsError(try leg.addScore(score: 12))
        { error in
            XCTAssertEqual(error as? LegError, LegError.invalidScore)
        }
    }
    
    func testGetScoreFromSingle()
    {
        let leg = Leg()
        XCTAssertNoThrow(try leg.addScore(score: 12))
        XCTAssertEqual(leg.Score, 12, "Leg should have correct score")
    }
    
    func testGetScoreFromMultiple()
    {
        let leg = Leg()
        XCTAssertNoThrow(try leg.addScore(score: 12))
        XCTAssertNoThrow(try leg.addScore(score: 100))
        XCTAssertEqual(leg.Score, 112, "Leg should have correct score")
    }
}
