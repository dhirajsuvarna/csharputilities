<DFMExpress Name="" Createdby="" CreatedOn="" Unit="0" AngularUnit="0" Version="v3.2"><Rule Name="Minimum Radius at Base of Boss" Status="0" LifeStatus="1" Summary="Ratio of radius at the base of boss to nominal wall thickness should be &gt;= 0.25. Minimum radius at the base of boss should be &gt;= 0.4 mm." Module="dfmimrulesvalidator" RuleModule="Injection Molding Rules" RuleModuleFileName="dfmimrulesu.dll" Severity="2" RuleCategory="Injection Molding"><Parameter Name="Boss Base Radius to Nominal Wall Thickness" Type="2054" Status="1"><Operator>7</Operator><ParameterType>1</ParameterType><Value>0.250000</Value><Remarks></Remarks></Parameter><Parameter Name="Minimum Radius" Type="2055" Status="1"><Operator>7</Operator><ParameterType>1</ParameterType><Value>0.400000</Value><Remarks></Remarks></Parameter></Rule><Rule Name="Minimum Radius at Tip of Boss" Status="0" LifeStatus="1" Summary="Minimum radius at the tip of boss should be &gt;= 0.2 mm." Module="dfmimrulesvalidator" RuleModule="Injection Molding Rules" RuleModuleFileName="dfmimrulesu.dll" Severity="2" RuleCategory="Injection Molding"><Parameter Name="Minimum Radius" Type="2066" Status="1"><Operator>7</Operator><ParameterType>1</ParameterType><Value>0.200000</Value><Remarks></Remarks></Parameter></Rule><Rule Name="Rib Reinforcement Check" Status="0" LifeStatus="1" Summary="The ratio of the rib cross sectional area to nominal wall thickness should be &lt;= 5.0 mm.The ratio of the rib height to nominal wall thickness should be &lt;= 3.0.The ratio of the rib width to nominal wall thickness should be &lt;= 2.0." Module="dfmimrulesvalidator" RuleModule="Injection Molding Rules" RuleModuleFileName="dfmimrulesu.dll" Severity="3" RuleCategory="Injection Molding"><Parameter Name="Rib Cross Sectional Area to Nominal Wall Thickness" Type="2077" Status="1"><Operator>8</Operator><ParameterType>1</ParameterType><Value>5.000000</Value><Remarks></Remarks></Parameter><Parameter Name="Rib Height To Nominal Wall Thickness" Type="2102" Status="1"><Operator>8</Operator><ParameterType>1</ParameterType><Value>3.000000</Value><Remarks></Remarks></Parameter><Parameter Name="Rib Width To Nominal Wall Thickness" Type="2103" Status="1"><Operator>8</Operator><ParameterType>1</ParameterType><Value>2.000000</Value><Remarks></Remarks></Parameter></Rule><Rule Name="Maximum Cutout Area" Status="0" LifeStatus="1" Summary="Ratio of cutout area to nominal wall thickness should be &lt;= 10.0 mm." Module="dfmimrulesvalidator" RuleModule="Injection Molding Rules" RuleModuleFileName="dfmimrulesu.dll" Severity="3" RuleCategory="Injection Molding"><Parameter Name="Maximum Cutout Area to Nominal Wall Thickness" Type="2081" Status="1"><Operator>8</Operator><ParameterType>1</ParameterType><Value>10.000000</Value><Remarks></Remarks></Parameter></Rule><Rule Name="Recommended Rib Parameters" Status="0" LifeStatus="1" Summary="Ratio of rib thickness to nominal wall thickness should be &lt;= 0.6. Ratio of rib height to nominal wall thickness should be &lt;= 3.0.Ratio of rib width to nominal wall thickness should be &lt;= 2.0." Module="dfmimrulesvalidator" RuleModule="Injection Molding Rules" RuleModuleFileName="dfmimrulesu.dll" Severity="2" RuleCategory="Injection Molding"><Parameter Name="Rib Thickness to Nominal Wall Thickness" Type="2083" Status="1"><Operator>8</Operator><ParameterType>1</ParameterType><Value>0.600000</Value><Value>1.000000</Value><Remarks></Remarks></Parameter><Parameter Name="Rib Height to Nominal Wall Thickness" Type="2084" Status="1"><Operator>8</Operator><ParameterType>1</ParameterType><Value>3.000000</Value><Remarks></Remarks></Parameter><Parameter Name="Rib Width to Nominal Wall Thickness" Type="2085" Status="1"><Operator>8</Operator><ParameterType>1</ParameterType><Value>2.000000</Value><Remarks></Remarks></Parameter></Rule><Rule Name="Minimum Draft Angle" Status="0" LifeStatus="1" Summary="Draft angle for core should be &gt;= 0.5 deg and draft angle for cavity should be &gt;= 5.0 deg." Module="dfmimrulesvalidator" RuleModule="Injection Molding Rules" RuleModuleFileName="dfmimrulesu.dll" Severity="2" RuleCategory="Injection Molding"><Parameter Name="Minimum Draft Angle For Core" Type="2120" Status="1"><Operator>7</Operator><ParameterType>2</ParameterType><Value>0.500000</Value><Remarks></Remarks></Parameter><Parameter Name="Minimum Draft Angle For Cavity" Type="2121" Status="1"><Operator>7</Operator><ParameterType>2</ParameterType><Value>5.000000</Value><Remarks></Remarks></Parameter></Rule><Rule Name="Undercut Detection" Status="0" LifeStatus="1" Summary="Undercuts should be avoided for ease of manufacturing." Module="dfmimrulesvalidator" RuleModule="Injection Molding Rules" RuleModuleFileName="dfmimrulesu.dll" Severity="3" RuleCategory="Injection Molding"/><Rule Name="Undercut Interference Check" Status="0" LifeStatus="1" Summary="Thickness of Mold =  4.0 mm Overhang of Mold(ALPHA) =  0.0 mm Required Gap =  1.0 mm" Module="dfmimrulesvalidator" RuleModule="Injection Molding Rules" RuleModuleFileName="dfmimrulesu.dll" Severity="1" RuleCategory="Injection Molding"><Parameter Name="Thickness of Mold" Type="2178" Status="1"><Operator>7</Operator><ParameterType>1</ParameterType><Value>4.000000</Value><Remarks></Remarks></Parameter><Parameter Name="Overhang of Mold(ALPHA)" Type="2179" Status="1"><Operator>8</Operator><ParameterType>1</ParameterType><Value>0.000000</Value><Remarks></Remarks></Parameter><Parameter Name="Required Gap" Type="2180" Status="1"><Operator>8</Operator><ParameterType>1</ParameterType><Value>1.000000</Value><Remarks></Remarks></Parameter></Rule><Rule Name="Snap fit - Mold Parameters" Status="0" LifeStatus="1" Summary="A &gt;= 0.5 mm. C &lt;= 3.0 X B." Module="dfmimrulesvalidator" RuleModule="Injection Molding Rules" RuleModuleFileName="dfmimrulesu.dll" Severity="1" RuleCategory="Injection Molding"><Parameter Name="Snap fit mold param A" Type="2185" Status="1"><Operator>7</Operator><ParameterType>1</ParameterType><Value>0.500000</Value><Remarks></Remarks></Parameter><Parameter Name="Snap fit param C to B ratio" Type="2192" Status="1"><Operator>8</Operator><ParameterType>1</ParameterType><Value>3.000000</Value><Remarks></Remarks></Parameter></Rule><Rule Name="Core-Cavity Surface Area Ratio" Status="0" LifeStatus="1" Summary="Core-Cavity Surface Area Ratio" Module="dfmimrulesvalidator" RuleModule="Injection Molding Rules" RuleModuleFileName="dfmimrulesu.dll" Severity="1" RuleCategory="Injection Molding"/><Rule Name="Maximum Rib Height for Rib Thickness" Status="0" LifeStatus="1" Summary="Maximum rib height should be in relation to rib thickness as specified in table." Module="dfmimrulesvalidator" RuleModule="Injection Molding Rules" RuleModuleFileName="dfmimrulesu.dll" Severity="2" RuleCategory="Injection Molding"><Parameter Name="Maximum Rib Height" Type="2227" Status="1"><Operator>8</Operator><ParameterType>24</ParameterType><Value Attribute1="0.5" Attribute2="4.0"/><Remarks></Remarks></Parameter></Rule><Rule Name="Minimum Edge Radius for Rib" Status="0" LifeStatus="1" Summary="Rib edge radius to rib thickness ratio &gt;= 0.5" Module="dfmimrulesvalidator" RuleModule="Injection Molding Rules" RuleModuleFileName="dfmimrulesu.dll" Severity="2" RuleCategory="Injection Molding"><Parameter Name="Minimum Edge Radius for Rib" Type="2237" Status="1"><Operator>7</Operator><ParameterType>1</ParameterType><Value>0.500000</Value><Remarks></Remarks></Parameter><Parameter Name="Consider Rib Edges Without Fillet" Type="2238" Status="1"><Operator>3</Operator><ParameterType>1</ParameterType><Value>1.000000</Value><Remarks></Remarks></Parameter><Parameter Name="Horizontal Angles" Type="2246" Status="1"><Operator>3</Operator><ParameterType>8</ParameterType><Value>0.000000</Value><Value>0.000000</Value><Remarks></Remarks></Parameter><Parameter Name="Vertical Angles" Type="2247" Status="1"><Operator>3</Operator><ParameterType>8</ParameterType><Value>75.000000</Value><Value>90.000000</Value><Remarks></Remarks></Parameter><Parameter Name="Tilt Angles" Type="2248" Status="1"><Operator>3</Operator><ParameterType>8</ParameterType><Value>0.000000</Value><Value>75.000000</Value><Remarks></Remarks></Parameter></Rule><Rule Name="Recommended Corner Radius" Status="0" LifeStatus="1" Summary="(R- r) should " Module="dfmimrulesvalidator" RuleModule="Injection Molding Rules" RuleModuleFileName="dfmimrulesu.dll" Severity="2" RuleCategory="Injection Molding"><Parameter Name="Recommended Corner Operator" Type="2294" Status="1"><Operator>1</Operator><ParameterType>1</ParameterType><Remarks></Remarks></Parameter><Parameter Name="Recommended Corner From Value" Type="2295" Status="1"><Operator>7</Operator><ParameterType>1</ParameterType><Value>0.900000</Value><Remarks></Remarks></Parameter><Parameter Name="Recommended Corner To Value" Type="2296" Status="1"><Operator>7</Operator><ParameterType>1</ParameterType><Value>1.200000</Value><Remarks></Remarks></Parameter></Rule><Rule Name="Minimum Radius at Base of Rib" Status="0" LifeStatus="1" Summary="Ratio of radius at the base of rib to nominal wall thickness should be 0.0. Minimum radius at the base of rib should be &gt;= 0.381 mm." Module="DfmIMRulesValidator" RuleModule="Injection Molding Rules" RuleModuleFileName="dfmimrulesu.dll" Severity="2" RuleCategory="Injection Molding"><Parameter Name="Rib Base Radius to Nominal Wall Thickness" Type="2325" Status="1"><Operator>1</Operator><ParameterType>1</ParameterType><Value>0.000000</Value><Value>0.250000</Value><Value>0.500000</Value><Remarks></Remarks></Parameter><Parameter Name="Minimum Radius" Type="2330" Status="1"><Operator>7</Operator><ParameterType>1</ParameterType><Value>0.381000</Value><Remarks></Remarks></Parameter></Rule><Rule Name="Hole Depth To Diameter Ratio" Status="0" LifeStatus="1" Summary="Blind hole depth to diameter ratio should be &lt; 2.0; Through hole depth to diameter ratio should be &lt; 4.0." Module="dfmimrulesvalidator" RuleModule="Injection Molding Rules" RuleModuleFileName="dfmimrulesu.dll" Severity="2" RuleCategory="Injection Molding"><Parameter Name="Blind Hole Depth to Diameter Ratio" Type="2347" Status="1"><Operator>5</Operator><ParameterType>1</ParameterType><Value>2.000000</Value><Remarks></Remarks></Parameter><Parameter Name="Through Hole Depth to Diameter Ratio" Type="2348" Status="1"><Operator>5</Operator><ParameterType>1</ParameterType><Value>4.000000</Value><Remarks></Remarks></Parameter></Rule><Rule Name="Spacing Between Holes" Status="0" LifeStatus="1" Summary="Spacing between holes to nominal wall thickness ratio should be &gt;2.0." Module="dfmimrulesvalidator" RuleModule="Injection Molding Rules" RuleModuleFileName="dfmimrulesu.dll" Severity="2" RuleCategory="Injection Molding"><Parameter Name="Spacing Between Holes" Type="2374" Status="1"><Operator>6</Operator><ParameterType>1</ParameterType><Value>2.000000</Value><Remarks></Remarks></Parameter></Rule><Rule Name="Minimum Draft For Ribs" Status="0" LifeStatus="1" Summary="Minimum draft on rib should be &gt;= 0.5 deg" Module="DfmIMRulesValidator" RuleModule="Injection Molding Rules" RuleModuleFileName="dfmimrulesu.dll" Severity="2" RuleCategory="Injection Molding"><Parameter Name="Minimum Draft For Ribs parameters" Type="2406" Status="1"><Operator>7</Operator><ParameterType>2</ParameterType><Value>0.500000</Value><Value>1.500000</Value><Remarks></Remarks></Parameter></Rule><Rule Name="Recommended Bottom Radius for Lip" Status="0" LifeStatus="1" Summary="Radius at the bottom of lip should be &gt;=  2.0 times the minimum thickness of lip feature." Module="DfmIMRulesValidator" RuleModule="Injection Molding Rules" RuleModuleFileName="dfmimrulesu.dll" Severity="2" RuleCategory="Injection Molding"><Parameter Name="Bottom Radius to Lip Thickness Ratio" Type="2443" Status="1"><Operator>7</Operator><ParameterType>1</ParameterType><Value>2.000000</Value><Remarks></Remarks></Parameter></Rule><Rule Name="Shut-off Parameters" Status="0" LifeStatus="1" Summary="Shut-off Angle (A) &gt;=  5.0 deg. Shut-off Relief (D) &gt;=  1.5 mm." Module="DfmIMRulesValidator" RuleModule="Injection Molding Rules" RuleModuleFileName="dfmimrulesu.dll" Severity="1" RuleCategory="Injection Molding"><Parameter Name="Shut-off Angle (A)" Type="2448" Status="1"><Operator>7</Operator><ParameterType>8</ParameterType><Value>5.000000</Value><Remarks></Remarks></Parameter><Parameter Name="Shut-off Relief (D)" Type="2449" Status="1"><Operator>7</Operator><ParameterType>1</ParameterType><Value>1.500000</Value><Remarks></Remarks></Parameter></Rule><Rule Name="Cored Hole Radius In Boss" Status="0" LifeStatus="1" Summary="Minimum cored hole radius in boss should be &gt;=  0.254 mm." Module="DfmIMRulesValidator" RuleModule="Injection Molding Rules" RuleModuleFileName="dfmimrulesu.dll" Severity="2" RuleCategory="Injection Molding"><Parameter Name="Cored Hole Radius (R)" Type="2460" Status="1"><Operator>7</Operator><ParameterType>1</ParameterType><Value>0.254000</Value><Value>0.350000</Value><Remarks></Remarks></Parameter></Rule><Rule Name="Minimum Draft For Bosses" Status="0" LifeStatus="1" Summary="Minimum draft on the boss ID should be &gt;=  0.25 deg. Minimum draft on the boss OD should be &gt;=  0.5 deg." Module="DfmIMRulesValidator" RuleModule="Injection Molding Rules" RuleModuleFileName="dfmimrulesu.dll" Severity="2" RuleCategory="Injection Molding"><Parameter Name="Minimum Draft for Boss ID (Q1)" Type="2468" Status="1"><Operator>7</Operator><ParameterType>8</ParameterType><Value>0.250000</Value><Remarks></Remarks></Parameter><Parameter Name="Minimum Draft for Boss OD (Q2)" Type="2469" Status="1"><Operator>7</Operator><ParameterType>8</ParameterType><Value>0.500000</Value><Remarks></Remarks></Parameter></Rule><Rule Name="Boss Spacing" Status="0" LifeStatus="1" Summary="The ratio of minimum spacing between two bosses to nominal wall thickness should be &gt;= 2.0." Module="DfmIMRulesValidator" RuleModule="Injection Molding Rules" RuleModuleFileName="dfmimrulesu.dll" Severity="2" RuleCategory="Injection Molding"><Parameter Name="Minimum Distance" Type="2489" Status="1"><Operator>7</Operator><ParameterType>1</ParameterType><Value>2.000000</Value><Remarks></Remarks></Parameter></Rule><Rule Name="Recommended Boss Parameters" Status="0" LifeStatus="1" Summary="The maximum ratio of boss outer diameter (D2) to inner diameter (D1) should be &lt;=  2.0. The maximum ratio of boss height (H) to outer diameter (D2) should be &lt;=  3.0. The ratio of boss height to nominal wall thickness should be &lt;=  5.0" Module="DfmIMRulesValidator" RuleModule="Injection Molding Rules" RuleModuleFileName="dfmimrulesu.dll" Severity="2" RuleCategory="Injection Molding"><Parameter Name="Boss OD to ID Ratio (D2/D1)" Type="2497" Status="1"><Operator>8</Operator><ParameterType>1</ParameterType><Value>2.000000</Value><Remarks></Remarks></Parameter><Parameter Name="Boss Height to OD Ratio (H/D2)" Type="2498" Status="1"><Operator>8</Operator><ParameterType>1</ParameterType><Value>3.000000</Value><Remarks></Remarks></Parameter><Parameter Name="Boss Height to Nominal Wall Thickness Ratio(H/t)" Type="2567" Status="1"><Operator>8</Operator><ParameterType>1</ParameterType><Value>5.000000</Value><Remarks></Remarks></Parameter></Rule><Rule Name="Draft Angle Based on Height" Status="0" LifeStatus="1" Summary="Minimum draft angle on core and cavity should be as per value configured in the table." Module="DfmIMRulesValidator" RuleModule="Injection Molding Rules" RuleModuleFileName="dfmimrulesu.dll" Severity="2" RuleCategory="Injection Molding"><Parameter Name="Variable Draft Angle Parameters" Type="2601" Status="1"><Operator>3</Operator><ParameterType>24</ParameterType><Value Attribute1="0.0" Attribute2="50.8" Attribute3="1.91" Attribute4="1.43"/><Value Attribute1="50.8" Attribute2="101.6" Attribute3="1.432" Attribute4="1.14"/><Value Attribute1="101.6" Attribute2="1000000000.0" Attribute3="1.146" Attribute4="0.95"/><Remarks></Remarks></Parameter></Rule><Rule Name="Rib Parameters For Recessed Boss" Status="0" LifeStatus="1" Summary="Ratio of rib height to nominal wall thickness should be &gt;=  4.0. Ratio of rib width to nominal wall thickness should be &gt;=  2.0. " Module="DfmIMRulesValidator" RuleModule="Injection Molding Rules" RuleModuleFileName="dfmimrulesu.dll" Severity="2" RuleCategory="Injection Molding"><Parameter Name="Rib Width" Type="2625" Status="1"><Operator>7</Operator><ParameterType>1</ParameterType><Value>2.000000</Value><Remarks></Remarks></Parameter><Parameter Name="Rib Height" Type="2626" Status="1"><Operator>7</Operator><ParameterType>1</ParameterType><Value>4.000000</Value><Remarks></Remarks></Parameter></Rule><Rule Name="Boss Recess Parameters" Status="0" LifeStatus="1" Summary="Boss recess diameter (D) should be &gt;=  3.0 mm. Ratio of boss recess height (H) to nominal wall thickness (t) should be &gt;=  3.0." Module="DfmIMRulesValidator" RuleModule="Injection Molding Rules" RuleModuleFileName="dfmimrulesu.dll" Severity="2" RuleCategory="Injection Molding"><Parameter Name="Recess Condition" Type="2659" Status="1"><Operator>7</Operator><ParameterType>1</ParameterType><Value>0.500000</Value><Remarks></Remarks></Parameter><Parameter Name="Recess Diameter" Type="2660" Status="1"><Operator>7</Operator><ParameterType>1</ParameterType><Value>3.000000</Value><Remarks></Remarks></Parameter><Parameter Name="Recess Height" Type="2661" Status="1"><Operator>7</Operator><ParameterType>1</ParameterType><Value>3.000000</Value><Remarks></Remarks></Parameter></Rule></DFMExpress>