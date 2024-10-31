import SwiftUI

struct ContentView: View {
    
    @State private var inputText = ""
    @State private var outputText = ""

    private let checkoutReader = CheckoutReader();
    
    var body: some View {
        VStack {
            TextField("Enter number", text: $inputText)
                .keyboardType(.numberPad)
                .padding()
                .textFieldStyle(RoundedBorderTextFieldStyle())
                .onChange(of: inputText) { newValue in
                    // Ensure only numeric input
                    let filtered = newValue.filter { "0123456789".contains($0) }
                    if filtered != newValue {
                        inputText = filtered
                    }
                }
            
            Button("Calculate Checkout") {
                if let array = checkoutReader.getArray(for: Int(inputText) ?? 0) {
                    outputText = array.map { "\($0)" }.joined(separator: ", ")
                } else {
                    outputText = "No array found for the given number."
                }
            }
            .disabled((Int(inputText) ?? 0) >= 170)
            .padding()

            Text("Entered number: \(outputText)")
                .padding()
        }
        .padding()
    }
}

#Preview {
    ContentView()
}
